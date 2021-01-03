using Library.Models;
using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Authorize(Roles = "admin")]

    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UsersWithRoles(int pageNumber = 1)
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();

            var itemsToSkip = (pageNumber * AppConstants.ItemsPerPage) - AppConstants.ItemsPerPage;
            var dataToDisplay = users.Skip(itemsToSkip).Take(AppConstants.ItemsPerPage);

            var model = new List<UserWithRolesModel>();

            foreach (var user in dataToDisplay)
            {
                var roles = await _userManager.GetRolesAsync(user);

                model.Add(new UserWithRolesModel() { Roles = string.Join(", ", roles), ApplicationUser = user });
            }
            var pagingInfo = new PaginationDetails()
            {
                TotalItems = users.Count(),
                CurrentPage = pageNumber,
                ItemsPerPage = AppConstants.ItemsPerPage,
                Url = "/Users/UsersWithRoles"
            };

            var viewModel = new UserWithRolesViewModel() { PageModel = pagingInfo, Users = model };

            return View(viewModel);

        }
        public IActionResult GetUsers()
        {
            return Ok(_unitOfWork.UserRepository.GetAll());
        }
    }
}
