using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class MaxMin
    {
        public void FindMindist()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrItem;
            }
            var stredArray = arr.OrderBy(x => x).ToArray();
          
            long mindist = Int64.MaxValue;
            if (k < n)
            {
                for (int i = 0; i <= n - k; i++)
                {
                    mindist = Math.Min(stredArray[i + k - 1] - stredArray[i], mindist);
                    
                }
            }
            else
            {
                 mindist = stredArray[n - 1] - stredArray[0];
            }

            Console.WriteLine($"Minum dist is {mindist}");
        }
    }
}
