using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class TaumandBday
    {
        public void taumBday()
        {
            // no of black and white gifts
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long b = Convert.ToInt64(firstMultipleInput[0]);

            long w = Convert.ToInt64(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long bc = Convert.ToInt64(secondMultipleInput[0]);

            long wc = Convert.ToInt64(secondMultipleInput[1]);

            long z = Convert.ToInt64(secondMultipleInput[2]);

            if (bc + z < wc)
            {
                wc = bc + z;
            }
            else if(wc + z < bc)
            {
                bc = wc + z;
            }
            long finalamt = bc * b + wc * w;
            Console.WriteLine(finalamt);

        }
    }
}
