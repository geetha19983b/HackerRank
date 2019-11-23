using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
namespace HackerRank_HomeCode
{
    public class ExtraLongFactorial
    {
        public void DisplayFact()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var bigFact = BigInteger.One;

            for(int i = 1;i <=n;i++)
            {
                bigFact = bigFact * i;
            }
            Console.WriteLine(bigFact);
        }
    }
}
