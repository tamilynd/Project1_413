using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_413.Models
{
    //Model with functions that bring in the day and times need to display reservation times on SignUp View
    public class SignUpViewModel
    {
        //Function to get the days in a list for the view
        public static List<String> GetDays() 
        {
            //Create string array
            List<String> days = new List<string>();

            //Add days to the string
            days.Add("Sunday");
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");

            return days;
        }

        //Function to get the times in a list of dictionaries for the view
        public static List<Dictionary<string, string>> GetTimes()
        {
           //declare list to hold time dictionaries
            List<Dictionary<string, string>> times = new List<Dictionary<string, string>>();

            //add time dictionaries to the list
            Dictionary<string, string> Time = new Dictionary<string, string>();
            Time.Add("start", "8:00 am");
            Time.Add("finish", "9:00 am");
            times.Add(Time);

            Time.Add("start", "9:00 am");
            Time.Add("finish", "10:00 am");
            times.Add(Time);

            Time.Add("start", "10:00 am");
            Time.Add("finish", "11:00 am");
            times.Add(Time);

            Time.Add("start", "11:00 am");
            Time.Add("finish", "12:00 pm");
            times.Add(Time);

            Time.Add("start", "12:00 pm");
            Time.Add("finish", "1:00 pm");
            times.Add(Time);

            Time.Add("start", "1:00 pm");
            Time.Add("finish", "2:00 pm");
            times.Add(Time);

            Time.Add("start", "2:00 pm");
            Time.Add("finish", "3:00 pm");
            times.Add(Time);

            Time.Add("start", "3:00 pm");
            Time.Add("finish", "4:00 pm");
            times.Add(Time);

            Time.Add("start", "4:00 pm");
            Time.Add("finish", "5:00 pm");
            times.Add(Time);

            Time.Add("start", "5:00 pm");
            Time.Add("finish", "6:00 pm");
            times.Add(Time);

            Time.Add("start", "6:00 pm");
            Time.Add("finish", "7:00 pm");
            times.Add(Time);

            Time.Add("start", "7:00 pm");
            Time.Add("finish", "8:00 pm");
            times.Add(Time);

            Time.Add("start", "8:00 pm");
            Time.Add("finish", "9:00 pm");
            times.Add(Time);

            return times;
        }
        
    }
}
