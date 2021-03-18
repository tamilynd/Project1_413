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
        public IActionResult SignUp(SignUpFormViewModel form)
        {

            return View("SignUpForm", form);
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
            return View(_repository.Appointments);
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
