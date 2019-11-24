using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MinimumDistances
    {
        public void FindMinDist()
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            var hset = new Dictionary<int, int>();
            var mindist = -1;

            for(int i = 0;i<a.Length;i++)
            {
                if(hset.ContainsKey(a[i]))
                {
                    if(mindist == -1)
                    {
                        mindist = i - hset[a[i]];
                        
                    }
                    else if (i - hset[a[i]] < mindist)
                    {
                        mindist = i - hset[a[i]];
                    }
                }
                else
                {
                    hset.Add(a[i], i);
                }
            }

            Console.WriteLine(mindist);

       
        }
    }
}
