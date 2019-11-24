using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class FairRations
    {
        public void findBreadLoves()
        {
            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
        ;
            int noOfBreads = 0;
            for(int i = 0;i <B.Length - 1;i++)
            {
                if(B[i] % 2 == 1)
                {
                    B[i] += 1;
                    B[i + 1] += 1;
                    noOfBreads += 2;
                }
            }
            if (B[B.Length - 1] % 2 == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine(noOfBreads);
            }
        }
    }
}
