using ItemStoreProject.Models;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Authorize(Roles = "Admin")]
        [HttpGet("category")]
        public IActionResult Category()
        {
            List<Category> Items = new List<Category>();
            Items = _dbContext.Categories.OrderBy(o => o.name).ToList();
            var model = new CategoryViewModel();
            model.Categories = Items;
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("updateCategoryName")]
        public IActionResult updateCategoryName(Category model)
        {
            model.name = model.name.Trim();
            _dbContext.Categories.Update(model);
            _dbContext.SaveChanges();
            return Redirect("/account/category");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("addCategoryName")]
        public IActionResult addCategoryName(Category model)
        {
            _dbContext.Categories.Add(model);
            _dbContext.SaveChanges();
            return Redirect("/account/category");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("removeCategoryName")]
        public IActionResult removeCategoryName(Category model)
        {
            _dbContext.Categories.Remove(model);
            _dbContext.SaveChanges();
            return Redirect("/account/category");

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
                await _userManager.AddToRoleAsync(user, "RegisteredUser");
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAction(LoginViewModel model, [FromQuery] string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var getUserResult = await _userManager.FindByEmailAsync(model.Email);
                await _signInManager.SignOutAsync();

                var signInResult = await _signInManager.PasswordSignInAsync(getUserResult, model.Password, false, false);
                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    //return RedirectToAction("login", new { Email = model.Email });
                    return View("Login", new LoginViewModel()
                    {
                        Email = model.Email
                    });
                }

            }
            else
            {
                return RedirectToAction("index", "home", new { Title = "Invalid model", whatever = ModelState.Values });
                //return View("Index", new HomeViewModel
                //{
                //    Title = "Invalid model",
                //    whatever = ModelState.Values
                //});
            }
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                //return View("Index", new HomeViewModel
                //{
                //    Title = "Successfully logged out!"
                //});
                return RedirectToAction("index", "home", new { Title = "Succesfully logged out!" });

            }
            catch (Exception e)
            {
                return RedirectToAction("index", "home", new { Title = "An unexpected error occired while trying to logut!", whatever = e });
                //return View("Index", new HomeViewModel
                //{
                //    Title = "An unexpected error occured while trying to logout!",
                //    whatever = e
                //});
            }

        }
    }
}