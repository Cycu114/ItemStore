using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ItemStoreProject.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PageNotFound()
        {
            return View();
        }
        public IActionResult DefaultErrorPage()
        {
            return View();
        }
    }
}