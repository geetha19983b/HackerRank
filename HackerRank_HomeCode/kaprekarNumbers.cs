using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class kaprekarNumbers
    {
        public void FindkaprekarNumbers()
        {
            long p = Convert.ToInt64(Console.ReadLine());

            long q = Convert.ToInt64(Console.ReadLine());

            var printInvalidRange = true;
            for (var n = p; n <= q; n++)

            {

                var kpnf = false;
                var square = n * n;
                var digitLength = n.ToString().Length;
                var squareLength = square.ToString().Length;

                long rdigt = long.Parse(square.ToString().Substring(squareLength - digitLength));
                long ldigit = 0;
                if (squareLength - digitLength > 0 )
                {
                    ldigit = long.Parse(square.ToString().Substring(0,squareLength - digitLength));
                }

                if(ldigit + rdigt == n)
                {
                    kpnf = true;
                    printInvalidRange = false;
                    Console.Write(n);

                }
                 if(kpnf)
                {
                    Console.Write(' ');
                }



            }
            if (printInvalidRange)
                Console.WriteLine("INVALID RANGE");
        }
    }
}
