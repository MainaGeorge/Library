using Library.Data;
using Library.Models;
using Library.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
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

            var addUserToRole = await _userManager.AddToRoleAsync(appUser, AppConstants.RegularUser);

            if (!addUserToRole.Succeeded)
            {
                AddModelErrors(addUserToRole);
                return View(model);
            }

            await _signInManager.SignInAsync(appUser, false);

            return RedirectToAction("Index", "Books");

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

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(Index), "Home");
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
