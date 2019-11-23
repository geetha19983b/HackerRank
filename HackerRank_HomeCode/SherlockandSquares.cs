using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class SherlockandSquares
    {
        public void FindSquareNoInbetween()
        {
            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            a = Convert.ToInt32(Math.Ceiling(Math.Sqrt(a)));
            b = Convert.ToInt32(Math.Floor(Math.Sqrt(b)));
            int nofSqrnubrs = b - a + 1;

            Console.WriteLine(nofSqrnubrs);
        }
    }
}
