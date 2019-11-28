using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BubbleSort
    {
        public void FindNoofSwaps()
        {
            int n = Convert.ToInt32(Console.ReadLine());


            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int swap = 0;
            int temp;
            for (int k = 0; k < n - 1; k++)
            {
                // (n-k-1) is for ignoring comparisons of elements which have already been compared in earlier iterations

                for (int i = 0; i < n - k - 1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        // here swapping of positions is being done.
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swap++;
                    }
                }
            }
            Console.WriteLine(swap);
        }
    }
}
