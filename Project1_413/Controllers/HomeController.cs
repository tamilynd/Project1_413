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
        private AppointmentListContext context { get; set; }

        public HomeController(AppointmentListContext con)
        {
            context = con;
        }


        public IActionResult Index()
        {
            return View();
        }

        //Pull up sign up page
        [HttpGet]
        public IActionResult SignUp()
        {

            return View();
        }


        [HttpPost]
        public IActionResult SignUp(string StartTime, string EndTime, string Day)
        {
            ViewBag.StartTime = StartTime;
            ViewBag.EndTime = EndTime;
            ViewBag.Day = Day;

            System.Diagnostics.Debug.WriteLine(StartTime);
            System.Diagnostics.Debug.WriteLine("This works");


            return View("SignUpForm");
        }


        public IActionResult SubmitForm(Appointment appointment)
        {
            //add to database
            context.Appointments.Add(appointment);
            context.SaveChanges();

            return View("Index");
        }


        public IActionResult ViewAppointments()
        {
            List<string> days = SignUpViewModel.GetDays();
            ViewBag.days = days;
            List<string> start = SignUpViewModel.GetStartTimes();
            ViewBag.start = start;
            List<string> finish = SignUpViewModel.GetFinishTimes();
            ViewBag.finish = finish;

            return View(context.Appointments);
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