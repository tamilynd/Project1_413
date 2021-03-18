using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Models
{
    //Class to allow the transfer of data through the model to the view for SignUpForm View
    public class SignUpFormViewModel
    {
        //Holds reservation day
        public string Day { get; set; }

        //Holds reservation start time
        public string StartTime { get; set; }

        //Holds reservation end time
        public string EndTime { get; set; }


    }
}
