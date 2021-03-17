using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            AppointmentListContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<AppointmentListContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Appointments.Any())
            {
                context.Appointments.AddRange(

                    new Appointment
                    {
                        Date = "3/21/21",
                        StartTime = "8:00am",
                        EndTime = "9:00am",
                        GroupName = "Hilton",
                        GroupSize = 8,
                        EmailAddress = "spencer.hilton@byu.edu",
                        PhoneNumber = 555 - 555 - 5555
                    },

                    new Appointment
                    {
                        Date = "3/23/21",
                        StartTime = "10:00am",
                        EndTime = "11:00am",
                        GroupName = "Wells",
                        GroupSize = 5,
                        EmailAddress = "taylor.wells@byu.edu",
                        PhoneNumber = 555 - 555 - 5555

                    },

                    new Appointment
                    {
                        Date = "3/20/21",
                        StartTime = "1:00pm",
                        EndTime = "2:00pm",
                        GroupName = "Potter Puppet Pals",
                        GroupSize = 7,
                        EmailAddress = "potterpuppetpals@hogwarts.com",
                        PhoneNumber = 555 - 555 - 5555
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}