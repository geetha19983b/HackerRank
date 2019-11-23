using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class Kangaroo
    {
        public void DoTheyMeet()
        {
            var tokens_x1 = Console.ReadLine().Split(' ');
            var x1 = Convert.ToInt32(tokens_x1[0]);
            var v1 = Convert.ToInt32(tokens_x1[1]);
            var x2 = Convert.ToInt32(tokens_x1[2]);
            var v2 = Convert.ToInt32(tokens_x1[3]);
            var sameLocationPossible = "";
            if (x1 < x2  && v1 < v2)
            {
                sameLocationPossible = "NO";
            }
            else if(x2 < x1 && v2 < v1)
            {
                sameLocationPossible = "NO";
            }
            else if(x2 > x1)
            {
                var noOfjumps = ((double)(x2 - x1)) / (v1 - v2);

                if(noOfjumps % 1 == 0)
                {
                    sameLocationPossible = "YES";
                }
                else
                {
                    sameLocationPossible = "NO";
                }

            }
            else
            {
                var noOfjumps = ((double)(x1 - x2)) / (v2 - v1);

                if (noOfjumps % 1 == 0)
                {
                    sameLocationPossible = "YES";
                }
                else
                {
                    sameLocationPossible = "NO";
                }
            }

            Console.WriteLine(sameLocationPossible); 

        }
    }
}
