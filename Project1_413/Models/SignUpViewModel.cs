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
            days.Add("Monday");
            days.Add("Tuesday"); 
            days.Add("Wednesday"); 
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");

            return days;
        }

        //Function to get the times in a list of dictionaries for the view
        public static List<string> GetStartTimes()
        {
           //declare list to hold time dictionaries
            List<string> StartTimes = new List<string>();
            StartTimes.Add("8:00 am");
            StartTimes.Add("9:00 am");
            StartTimes.Add("10:00 am");
            StartTimes.Add("11:00 am");
            StartTimes.Add("12:00 pm");
            StartTimes.Add("1:00 pm");
            StartTimes.Add("2:00 pm");
            StartTimes.Add("3:00 pm");
            StartTimes.Add("4:00 pm");
            StartTimes.Add("5:00 pm");
            StartTimes.Add("6:00 pm");
            StartTimes.Add("7:00 pm");
            StartTimes.Add("8:00 pm");



            return StartTimes;
        }

        public static List<string> GetFinishTimes()
        {
            //declare list to hold time dictionaries
            List<string> FinishTimes = new List<string>();
            FinishTimes.Add("9:00 am");
            FinishTimes.Add("10:00 am");
            FinishTimes.Add("11:00 am");
            FinishTimes.Add("12:00 pm");
            FinishTimes.Add("1:00 pm");
            FinishTimes.Add("2:00 pm");
            FinishTimes.Add("3:00 pm");
            FinishTimes.Add("4:00 pm");
            FinishTimes.Add("5:00 pm");
            FinishTimes.Add("6:00 pm");
            FinishTimes.Add("7:00 pm");
            FinishTimes.Add("8:00 pm");
            FinishTimes.Add("9:00 pm");



            return FinishTimes;
        }
    }
}
