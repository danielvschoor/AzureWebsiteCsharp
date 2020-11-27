using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebsite.Controllers
{
    public class BlazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
