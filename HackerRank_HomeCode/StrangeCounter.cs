using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class StrangeCounter
    {
        public void CounterValue()
        {
            long t = Convert.ToInt64(Console.ReadLine());
            long cvalue;
            long upperBound = 4;
            long lowerBound = 1;
            long upperBoundValue = 6;

            while(t > upperBound)
            {
                lowerBound = upperBound;
                upperBound = upperBound + upperBoundValue;
                upperBoundValue = upperBound + 2;
            }

            if(t ==upperBound)
            {
                cvalue = upperBoundValue;
            }
            else
            {
                cvalue = lowerBound + 2 - (t - lowerBound);
            }

            Console.WriteLine(cvalue);

        }
    }
}
