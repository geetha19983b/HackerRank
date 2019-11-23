using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class FindDigits
    {
        public void CountNoOfDiv()
        {
            //enter the number
            int n = Convert.ToInt32(Console.ReadLine());
            var digCount = 0;

            foreach(var digit in n.ToString())
            {
                if (digit == '0')
                    continue;
               
                if ((n % (int)char.GetNumericValue(digit)) == 0)
                {
                    digCount++;
                }
            }
            Console.WriteLine(digCount);

        }
    }
}
