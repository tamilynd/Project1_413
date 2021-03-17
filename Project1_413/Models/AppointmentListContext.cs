using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Models
{
    public class AppointmentListContext : DbContext
    {
        public AppointmentListContext (DbContextOptions<AppointmentListContext> options) : base (options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
