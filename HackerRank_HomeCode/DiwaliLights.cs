using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace HackerRank_HomeCode
{
    public class DiwaliLights
    {
        public void FindNoOfPattern()
        {
            try

            {
                int n = Convert.ToInt32(Console.ReadLine());

                // long result = 0;

                //2 lights can be arranged in 2 pow 2 -1 possibility
                BigInteger num =BigInteger.Pow(2,n) -1;
                BigInteger den = new BigInteger(100000);
                BigInteger result = num % den;

                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
