using Library.Data;
using Library.Models;
using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountsController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 8)
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();

            var result = PaginateResult.PageResults(users, pageNumber, pageSize);

            return View(result);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var appUser = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.FirstName,
                Email = model.Email,
                DateOfBirth = model.DateOfBirth
            };

            var createdUser = await _userManager.CreateAsync(appUser, model.Password);

            if (!createdUser.Succeeded)
            {
                AddModelErrors(createdUser);
                return View(model);
            }

            await _signInManager.SignInAsync(appUser, false);

            return RedirectToAction(nameof(Index), "Books");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "wrong email password combination");
                return View(model);
            }

            var signIn = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (signIn.Succeeded)
                return RedirectToAction(nameof(Index), controllerName: "Books");

            ModelState.AddModelError(string.Empty, "invalid password email combination");

            return View(model);

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Index), "Books");
        }


        private void AddModelErrors(IdentityResult result)
        {
            foreach (var identityError in result.Errors)
            {
                ModelState.AddModelError(identityError.Code, identityError.Description);
            }
        }
    }
}
