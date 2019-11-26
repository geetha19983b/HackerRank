using System;
using System.Collections.Generic;
using System.Text;

//https://leetcode.com/explore/interview/card/top-interview-questions-easy/97/dynamic-programming/576/
//https://www.youtube.com/watch?v=ge_Fv2ZQAaE&list=PLSIpQf0NbcClDpWE58Y-oSJro_W3LO8Nb&index=4
namespace HackerRank_HomeCode
{
    public class Houserobber
    { 
        public void MAxSumWhichCanberobbbed()
        {
            
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));
            int max = 0;
            int n = nums.Length;
            if (n == 0)
                max = 0;
            if (n == 1)
                max = nums[0];

            int []dp = new int[n + 1];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0],nums[1]);
            max = dp[1];
            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
                max = Math.Max(max, dp[i]);
            }
            Console.WriteLine($"Max amount which the robber can rob is {max}"); 
        }
    }
}

//Input: [2,7,9,3,1]
//Output: 12
//Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
//             Total amount you can rob = 2 + 9 + 1 = 12.
