using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1_413.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        
         //Pass in time/date from SignUp page & set it equal to time/date on SignUpForm page
        public IActionResult SignUpForm(SignUpForm form, SignUpModel times)
        {
            //how to set parameters of signupform = to info coming from index page
            form.StartTime = times.StartTime;
            form.EndTime = times.EndTime;
            form.Date = times.Date;

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
