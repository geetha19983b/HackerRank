using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Twelveto24Hourconv
    {
        public void ConvertTwelveTo24Hour()
        {
            Console.WriteLine("Enter the time in HH:MM:SSAM/PM");
            string s = Console.ReadLine();
              
            string amOrpm = s.Substring(8, 2);
            var hour = s.Substring(0, 2);
            var remaining = s.Substring(2, 6);
            if (amOrpm == "AM" && hour == "12")
            {
                hour = "00";
            }
            else if (amOrpm == "PM")
            {
                if (hour != "12")
                {
                    hour = Convert.ToString(int.Parse(hour) + 12);
                }
            }
            Console.WriteLine(hour + remaining);
        }
    }
}
