using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class ServiceLane
    {
        public void MinWidth()
        {
            

            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
            ;

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] minwdth = new int[t];
            int idx = 0;
            for(int i = 0;i<t;i++)
            {
                var srtindx = cases[i][0];
                var endindx = cases[i][1];

                //Console.WriteLine($"Start index is {srtindx} and End index is {endindx}");
                int length = endindx - srtindx + 1;
                int[] tempArray = new int[length];
               
                Array.Copy(width, srtindx, tempArray, 0, length);
                //Array.ForEach(tempArray,x => Console.Write(x));
                var res = (from row in tempArray
                           select row).Min();
                minwdth[idx] = res;
                idx++;

            }
            Console.WriteLine("Min width which can pass");
            Array.ForEach(minwdth, x => Console.WriteLine(x));
        }
    }
}
