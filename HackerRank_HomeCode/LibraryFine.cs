using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class LibraryFine
    {
        public void FindDue()
        {
            //return date
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);
            //due date
            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);
            int fine = 0;

            if(y1 > y2)
            {
                fine = 10000;
            }
            else if(y1 == y2)
            {
                if(m1 > m2)
                {
                    fine = 500 * (m1 - m2);
                }
                else
                {
                    if(m1 == m2)
                    {
                        if(d1 > d2)
                        {
                            fine = 15 * (d1 - d2);
                        }
                    }
                }
            }
            Console.WriteLine(fine);
        }
    }
}
