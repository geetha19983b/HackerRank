using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class Consecutive1sInBinaryNumbers
    {
        public void countConsecutive1sInBinary()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number > 0)
            {
                number = number & (number << 1);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
