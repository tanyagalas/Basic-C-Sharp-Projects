using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstAzureWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h2>Welcome to My Web App!</h2>");
        }

        public IActionResult ServerTime()
        {
            var serverTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return Content($"The server time is: {serverTime}");
        }
    }
}