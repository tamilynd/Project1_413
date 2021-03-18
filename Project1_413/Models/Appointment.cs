using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Models
{
    public class Appointment
    {
        [Required]
        public string Date { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Phone]
        public long PhoneNumber { get; set; }


        public static Appointment[] GetAppointments()
        {
            {
                Appointment a1 = new Appointment()
                {
                    StartTime = "8:00am",
                    EndTime = "9:00am"
                };

                Appointment a2 = new Appointment()
                {
                    StartTime = "9:00am",
                    EndTime = "10:00am"
                };

                Appointment a3 = new Appointment()
                {
                    StartTime = "10:00am",
                    EndTime = "11:00am"
                };

                Appointment a4 = new Appointment()
                {
                    StartTime = "11:00am",
                    EndTime = "12:00pm"
                };

                Appointment a5 = new Appointment()
                {
                    StartTime = "12:00pm",
                    EndTime = "1:00pm"
                };

                Appointment a6 = new Appointment()
                {
                    StartTime = "1:00pm",
                    EndTime = "2:00pm"
                };

                Appointment a7 = new Appointment()
                {
                    StartTime = "2:00pm",
                    EndTime = "3:00pm"
                };

                Appointment a8 = new Appointment()
                {
                    StartTime = "3:00pm",
                    EndTime = "4:00pm"
                };

                Appointment a9 = new Appointment()
                {
                    StartTime = "4:00pm",
                    EndTime = "5:00pm"
                };

                Appointment a10 = new Appointment()
                {
                    StartTime = "5:00pm",
                    EndTime = "6:00pm"
                };

                Appointment a11 = new Appointment()
                {
                    StartTime = "6:00pm",
                    EndTime = "7:00pm"
                };

                Appointment a12 = new Appointment()
                {
                    StartTime = "7:00pm",
                    EndTime = "8:00pm"
                };

                Appointment a13 = new Appointment()
                {
                    StartTime = "8:00pm",
                    EndTime = "9:00pm"
                };



                return new Appointment[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13 };

            }

        }
    }
}
