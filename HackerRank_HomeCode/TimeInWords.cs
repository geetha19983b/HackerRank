using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class TimeInWords
    {
        public void GiveTimeInWords()
        {
            string result = "";
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            var hourWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven","tweleve"};
            var minuteWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                                    , "eleven", "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty"
                                    , "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight","twenty nine" };


            if (m == 0)
                result=$"{hourWords[h - 1]} o' clock";

            if ((m > 0 && m < 15) || (m > 15 && m < 30))
                result=$"{minuteWords[m - 1]} minutes past {hourWords[h - 1]}";

            if ((m > 30 && m < 45) || (m > 45 && m < 60))
                result=$"{minuteWords[60 - m - 1]} minutes to {hourWords[h]}";

            if (m == 15)
                result=$"quarter past {hourWords[h - 1]}";

            if (m == 30)
                result=$"half past {hourWords[h - 1]}";

            if (m == 45)
                result=$"quarter to {hourWords[h]}";

            Console.WriteLine(result);

        }
    }
}
