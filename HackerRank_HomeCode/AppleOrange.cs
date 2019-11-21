using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class AppleOrange
    {
        public void NoOfAppOrg()
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;

            int appleFallinginHouse = 0;
            int orngeFalinginHouse = 0;

            foreach(var apple in apples)
            {
                var applepos = apple + a;
                if(applepos >= s && applepos <= t)
                {
                    appleFallinginHouse++;
                }
            }

            foreach(var orange in oranges)
            {
                var orngpos = orange + b;
                if(orngpos >= s && orngpos <= t)
                {
                    orngeFalinginHouse++;
                }

            }
            Console.WriteLine(appleFallinginHouse);
            Console.WriteLine(orngeFalinginHouse);
        }
    }
}
