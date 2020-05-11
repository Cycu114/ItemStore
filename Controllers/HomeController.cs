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

namespace ItemStoreProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext dbContext, ILogger<HomeController> logger)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            _dbContext = dbContext;
            _logger = logger;
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
                Category = "Myju myju",
                ImgUrl = "https://penis.com"
            };

            var result = _dbContext.Products.Add(entity);

            _dbContext.SaveChanges();

            return Json(result.Entity);
        }

        [Authorize]
        [HttpGet("secret")]
        public IActionResult Secret()
        {
            return View();
        }
    }
}