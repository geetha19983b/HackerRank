using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class EqualSum
    {
        //https://hackerranksolutionc.blogspot.com/2017/09/equal-hackerrank-solution.html
        public void MinOps()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;

            Array.Sort(arr);
            long sum = Int64.MaxValue;
            for (int basei = 0; basei < 3; basei++)
            {
                int current_sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int delta = arr[i] - arr[0] + basei;
                    current_sum += (int)delta / 5 + delta % 5 / 2 + delta % 5 % 2 / 1;
                }
                sum = Math.Min(current_sum, sum);
            }
            Console.WriteLine(sum);
        }
    }
}

//delta/5 gives no of times you need to subtract 5
//then delta%5 gives what is left and divide by 2 give no of times 2 need to be subtracted,
//then left would be delta%5%2 and divide by one give how many subtraction by 1 is needed.