using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MaximumSumSubarray
    {

        //1 9 -1 -2 7 3 -1 -2
        //4 
        //ans 13
        public void getMaxSumOfsubarray()
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), arraTemp => Convert.ToInt32(arraTemp))
               ;
            //window length
            int k = Convert.ToInt32(Console.ReadLine());

            int windosum = 0, maxsum = 0;
            for(int i = 0;i <k;i++)
            {
                windosum += a[i];
            }

            for(int j = k;j <a.Length;j++)
            {
                windosum += a[j] - a[j - k];
                maxsum = Math.Max(windosum, maxsum);
            }
            Console.WriteLine(maxsum);
        }
    }
}
