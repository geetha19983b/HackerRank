using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.youtube.com/watch?v=ftpbBbtyxdE
    //walmart interview  question if a child has to reach n step and she can take 1 or 2 step
    //at a time then in how many ways she can reach the nth step
    public class DP_RecursiveStaircase
    {
        public void FindNoWaystoReachStairN()
        {
            //input the stair number
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 1, second = 1,sum = 0;
            if(n < 2)
            {
                Console.WriteLine(n);
                return;
            }

            for(int i = 2; i<=n; i++)
            {
                sum = first + second;
                first = second;
                second = sum;

            }

            Console.WriteLine($"No of ways the child can reach {n} stair is {sum}");
        }
    }
}
