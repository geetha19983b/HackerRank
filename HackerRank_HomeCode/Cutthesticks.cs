using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class Cutthesticks
    {
        public void findTheSticksCut()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            var sortedSticks = arr.OrderByDescending(x => x).ToList();

            int n = arr.Length;



            List<int> sticksCut_percycle = new List<int>();
           

            while (n > 0)
            {
                int stcks_cut = 0;
                int small_length = sortedSticks[n - 1];
                for (int i = n - 1; i >= 0; i--)
                {
                    stcks_cut++;
                    sortedSticks[i] -= small_length;
                    if(sortedSticks[i] == 0)
                    {
                        n--;
                    }
                }
                sticksCut_percycle.Add(stcks_cut);
                
            }
            int[] op = sticksCut_percycle.ToArray();
            Array.ForEach(op,x => Console.Write(x));
        }
    }
}
