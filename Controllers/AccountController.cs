using ItemStoreProject.Models;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ItemStoreProject.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
            AppDbContext dbContext, ILogger<HomeController> logger)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAction(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Email = model.Email,
                    UserName = model.UserName
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                var getResult = await _userManager.FindByNameAsync(model.UserName);

                if (result.Succeeded)
                {
                    return View("Index", new HomeViewModel()
                    {
                        Title = "Success",
                        whatever = getResult,
                    });
                }
                else
                {
                    return View("Index", new HomeViewModel()
                    {
                        Title = "Failure",
                        whatever = result.Errors,
                    });
                }
            }
            else
            {
                return View("Index", new HomeViewModel()
                {
                    Title = "Invalid model",
                    whatever = ModelState.Values
                });
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAction(LoginViewModel model, [FromQuery] string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var getUserResult = await _userManager.FindByEmailAsync(model.Email);
                var signInResult = await _signInManager.PasswordSignInAsync(getUserResult.UserName, model.Password, false, false);
                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return View("Index");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    return View("Login", new LoginViewModel()
                    {
                        Email = model.Email
                    });
                }
            }
            else
            {
                return View("Index", new HomeViewModel
                {
                    Title = "Invalid model",
                    whatever = ModelState.Values
                });
            }
        }

        public async Task<IActionResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return View("Index", new HomeViewModel
                {
                    Title = "Successfully logged out!"
                });

            }
            catch (Exception e)
            {
                return View("Index", new HomeViewModel
                {
                    Title = "An unexpected error occured while trying to logout!",
                    whatever = e
                });
            }

        }
    }
}