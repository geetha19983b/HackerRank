using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class DiagnoalDiff
    {
        public void CalculateDiagdiff()
        {
            List<List<int>> list = new List<List<int>>();
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                //
                // Put some integers in the inner lists.
                //
                List<int> sublist = new List<int>();
                //int top = rand.Next(1, 15);
                for (int v = 0; v < 3; v++)
                {
                    sublist.Add(rand.Next(1, 5));
                }
                //
                // Add the sublist to the top-level List reference.
                //
                list.Add(sublist);
            }
            foreach (var sublist in list)
            {

                foreach (var value in sublist)
                {

                    Console.Write(value);


                }

                Console.WriteLine();
            }

            int x = 0;
            int y = 0;
            int d1 = 0, d2 = 0;
            int count = list.Count;
            foreach (var sublist in list)
            {
                y = 0;
                foreach (var value in sublist)
                {

                    if (x == y)
                    {
                        d1 += value;
                    }
                    if ((count - (x + 1)) == y)
                    {
                        d2 += value;
                    }

                    // Console.Write("x is " + x  + "and y is " +y);
                    y++;
                }
                x++;

            }
            Console.WriteLine("diag diff is " + Math.Abs(d1 - d2));
        }
    }
}
