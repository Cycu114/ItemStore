using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItemStoreProject.Models;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Reflection;

namespace ItemStoreProject.Controllers
{
        
    [Route("")]
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext dbContext, ILogger<HomeController> logger, 
            RoleManager<IdentityRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            _dbContext = dbContext;
            _logger = logger;
            _roleManager = roleManager;
        }
        [Route("{*url}", Order = 999)]
        public IActionResult CatchAll()
        {
            Response.StatusCode = 404;
            return View("PageNotFound");
        }

        [HttpGet]
        [HttpGet("Home")]
        [HttpGet("Index")]
        [HttpGet("Index/{id?}")]
        public IActionResult Index([FromQuery] string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                var data = new HomeViewModel
                {
                    Title = title
                };

                return View(data);
            }

            return View();
        }

        [HttpGet("Privacy")]
        [HttpGet("Privacy/{id?}")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet("test")]
        public IActionResult Test()
        {
            var entity = new Product
            {
                Name = "Dezodorant",
                ImgUrl = "https://penis.com"
            };

            var result = _dbContext.Products.Add(entity);

            _dbContext.SaveChanges();

            return Json(result.Entity);
        }

        [Authorize(Roles = "RegisteredUser,Admin")]
        [HttpGet("secret")]
        public IActionResult Secret()
        {
            //var result = await _roleManager.CreateAsync(new IdentityRole("AnonymousUser"));
            return View();
        }

        //[Authorize]
        //[HttpGet("addAdminToRole")]
        //public async Task<IActionResult> addAdminToRole()
        //{
        //    var user = await _userManager.FindByEmailAsync("admin@gmail.com");
            
        //    var result = await _userManager.AddToRoleAsync(user, "Admin");
        //    if(result.Succeeded)
        //    return RedirectToAction("Index","Home", new { Title = "Success" });
        //    else
        //    {
        //        return RedirectToAction("Index", "Home", new { Title = "Failed" });
        //    }
        //}
    }
}