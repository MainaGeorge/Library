using Library.Models;
using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Authorize(Roles = "admin")]

    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersController(IUnitOfWork unitOfWork,
            UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UsersWithRoles(int pageNumber = 1)
        {
            var users = _unitOfWork.UserRepository
                .GetAll()
                .ToList();

            var itemsToSkip = (pageNumber * AppConstants.ItemsPerPage) - AppConstants.ItemsPerPage;
            var dataToDisplay = users.Skip(itemsToSkip).Take(AppConstants.ItemsPerPage);

            var model = new List<UserWithRolesModel>();

            foreach (var user in dataToDisplay)
            {
                var roles = await _userManager.GetRolesAsync(user);

                if (roles.Contains(AppConstants.AdminUser))
                    user.IsAdmin = true;

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

        public IActionResult BorrowedBooks()
        {
            var books = _unitOfWork.BookRepository.GetBorrowedBooks();
            return View(books);
        }
        public IActionResult GetUsers()
        {
            var loggedUserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var users = _unitOfWork.UserRepository.GetAll().Where(u => u.Id != loggedUserId);

            return Ok(users);
        }


        public async Task<IActionResult> MakeAdmin(string userId, int? pageNumber)
        {
            if (string.IsNullOrWhiteSpace(userId))
                return View("Error");

            pageNumber ??= 1;

            var user = _unitOfWork.UserRepository.GetById(userId);

            if (user == null)
                return View("Error");

            var makingAdmin = await _userManager.AddToRoleAsync(user, AppConstants.AdminUser);

            if (makingAdmin.Succeeded) return RedirectToAction(nameof(UsersWithRoles),
                "Users", new { pageNumber });

            return View("Error");


        }

        public async Task<IActionResult> RevokeAdmin(string userId, int? pageNumber)
        {
            if (string.IsNullOrWhiteSpace(userId))
                return View("Error");

            pageNumber ??= 1;

            var user = _unitOfWork.UserRepository.GetById(userId);

            if (user == null)
                return View("Error");

            var revokingAdmin = await _userManager.RemoveFromRoleAsync(user, AppConstants.AdminUser);

            if (revokingAdmin.Succeeded) return RedirectToAction(nameof(UsersWithRoles),
                "Users", new { pageNumber });

            return View("Error");
        }
    }
}
