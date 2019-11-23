using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class DivisibleSumPairs
    {
        public void NoOfSumPairs()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            var noofDivPairs = 0;
            for(int i = 0;i<n;i++)
            {
                for(int j = i + 1;j<n;j++)
                {
                    if((ar[i] + ar[j]) % k == 0)
                    {
                        noofDivPairs++;
                    }
                }
            }
            Console.WriteLine(noofDivPairs);
        }
    }
}
