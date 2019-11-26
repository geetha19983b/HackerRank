using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class PriyankaandToys
    {
        public void FindNofContainers()
        {
            int[] w = Array.ConvertAll(Console.ReadLine().Split(' '), wTemp => Convert.ToInt32(wTemp));

            Array.Sort(w);

            int min = w[0];
            int counter = 1;

            for(int i = 1;i<w.Length;i++)
            {
                if (w[i] <= min + 4)
                {
                    continue;
                }
                else
                {
                    counter++;
                    min = w[i];
                }
            }
            Console.WriteLine(counter);

        }
    }
}
