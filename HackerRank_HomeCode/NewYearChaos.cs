using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class NewYearChaos
    {
        public void NoOfBribes()
        {
            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            int swapCount = 0;

            for(int i = q.Length - 1;i >=0;i--)
            {
                if(q[i] != i + 1)
                {
                    if (((i - 1) >= 0) && q[i - 1] == (i + 1))
                    {
                        swapCount++;
                        swap(q, i, i - 1);
                    }
                    else if (((i - 2) >= 0) && q[i - 2] == (i + 1))
                    {
                        swapCount += 2;
                        swap(q, i - 2, i - 1);
                        swap(q, i - 1, i);
                    }
                    else
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }
            }
            Console.WriteLine(swapCount);

        }
        private static void swap(int[] arr,int a,int b)
        {

            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;

        }
    }
}
