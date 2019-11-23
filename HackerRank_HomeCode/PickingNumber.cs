using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class PickingNumber
    {
        public void fineMaxCombination()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int max = 0;

            var rs = (from row in a
                      orderby row ascending
                      select row).ToArray();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(rs[i]);
            //}
            //Console.WriteLine();
            for (int i = 0; i < a.Count; i++)
            {
                int cnt = 0;
                for (int j = i; j < a.Count; j++)
                {
                    //Console.Write(Math.Abs(rs[i] - rs[j]));
                    if (Math.Abs(rs[i] - rs[j]) <= 1)
                    {
                        cnt++;
                    }
                }
              //  Console.WriteLine("max is " + max + " cont is " + cnt);
                max = Math.Max(cnt, max);
            }
            Console.WriteLine(max); ;
        }
    }
}
