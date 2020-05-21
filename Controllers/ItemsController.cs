﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ItemStoreProject.Models;
using ItemStoreProject.Persistence;
using ItemStoreProject.Persistence.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ItemStoreProject.Controllers
{
    [Route("items")]
    public class ItemsController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;
        public ItemsController(UserManager<User> userManager, SignInManager<User> signInManager,
            AppDbContext dbContext, ILogger<HomeController> logger)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            _dbContext = dbContext;
            _logger = logger;
        }

        [Authorize]
        [HttpPost("addItemOffers")]
        public IActionResult addItemOffers(Offer model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var result = _dbContext.Offers.SingleOrDefault(x => (x.OwnerId == userId && x.Quantity == model.Quantity && x.Price == model.Price));
                if (result != null)
                {
                    result.Quantity += model.Quantity;
                    _dbContext.SaveChanges();
                }
                else
                {
                    model.OwnerId = userId;
                    _dbContext.Offers.Add(model);
                    _dbContext.SaveChanges();
                }
                return Redirect("offers");
            }
            else
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("offers/" + errorList);
            }
        }

        [Authorize]
        [HttpGet("offers/{errorMessage?}")]
        [HttpGet("offers")]
        public IActionResult Offers(string errorMessage)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            OfferViewModel model = new OfferViewModel();
            model.OwnerId = userId;
            model.Products = _dbContext.Products.ToList();
            model.Offers = _dbContext.Offers.Where(x => x.OwnerId == userId).ToList();
            if (errorMessage == null)
            {
                return View(model);
            }
            else
            {
                model.errorMessage = errorMessage;
                return View(model);
            }
        }

        [Authorize]
        [HttpGet("products/{errorMessage?}")]
        [HttpGet("Products")]
        public IActionResult Products(string errorMessage)
        {
            ProductViewModel Product = new ProductViewModel();
            Product.Products = _dbContext.Products.ToList();
            Product.Categories = _dbContext.Categories.OrderBy(o => o.Name).ToList();
            if (errorMessage == null)
            {
                return View(Product);
            }
            else
            {
                Product.errorMessage = errorMessage;
                return View(Product);
            }

        }

        [Authorize]
        [HttpPost("addProduct")]
        public IActionResult AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Add(model);
                _dbContext.SaveChanges();
                return Redirect("products");
            }
            else
            {
                var errorList = string.Join(" | ", ModelState.Values
                     .SelectMany(v => v.Errors)
                     .Select(e => e.ErrorMessage));
                return Redirect("products/" + errorList);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("category")]
        public IActionResult Category()
        {
            List<Category> Items = new List<Category>();
            Items = _dbContext.Categories.OrderBy(o => o.Name).ToList();
            var model = new CategoryViewModel();
            model.Categories = Items;
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("updateCategoryName")]
        public IActionResult updateCategoryName(Category model)
        {
            model.Name = model.Name.Trim();
            _dbContext.Categories.Update(model);
            _dbContext.SaveChanges();
            return Redirect("category");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("addCategoryName")]
        public IActionResult addCategoryName(Category model)
        {

            _dbContext.Categories.Add(model);
            _dbContext.SaveChanges();
            return Redirect("category");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("removeCategoryName")]
        public IActionResult removeCategoryName(Category model)
        {
            _dbContext.Categories.Remove(model);
            _dbContext.SaveChanges();
            return Redirect("category");

        }
    }
}