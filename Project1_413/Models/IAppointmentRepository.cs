using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Models
{
    public interface IAppointmentRepository
    {
        //Creates an Iqueryable of type Appointment for the repository
        IQueryable<Appointment> Appointments { get; }
    }
}
