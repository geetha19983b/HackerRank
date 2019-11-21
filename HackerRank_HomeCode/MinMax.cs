using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class MinMax
    {
        public void CalculateMinMax()
        {
            Console.WriteLine("Enter array of integer seperated by spaces");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            long minSum = 0;
            long maxSum = 0;
            long tempminSum = 0;
            long tempmaxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tempminSum = 0;
                tempmaxSum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        tempminSum += arr[j];
                        tempmaxSum +=  arr[j];
                       
                    }
                    
                }
               
                if (tempmaxSum > maxSum)
                {
                    maxSum = tempmaxSum;
                }
                if ((tempminSum < minSum) || (minSum ==0))
                {
                    minSum = tempminSum;
                }
            }
            Console.WriteLine("Min sum is " + minSum);
            Console.WriteLine("Max sum is " + maxSum);
        }
    }
}
