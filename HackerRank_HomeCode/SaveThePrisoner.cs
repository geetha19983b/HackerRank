using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class SaveThePrisoner
    {
        public void GettheLastPrisoner()
        {
            string[] nms = Console.ReadLine().Split(' ');
            //number of prisoners

            int n = Convert.ToInt32(nms[0]);
            //number of candies
            int m = Convert.ToInt32(nms[1]);
            //starting index
            int s = Convert.ToInt32(nms[2]);

            var remainingpr = n - s + 1;

            if(m > remainingpr)
            {
                s = 1;
                m = m - remainingpr;
                m = m % n;
            }

            if(m == 0)
            {
                s = n;
            }
            else
            {
                s = s + m - 1;
            }

            Console.WriteLine(s); 
        }
    }
}

