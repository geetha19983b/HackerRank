using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.ideserve.co.in/learn/maximum-subarray-sum
    public class MaximumSubArraySum
    {
        public void findMaxSuminSubArray()
        {
            int[] input = { 2, -9, 5, 1, -4, 6, 0, -7, 8 };
            int maxSum = 0;
            int maxnegsum = Int16.MinValue;
            int curSum = 0;
            bool hasallnegnumbers = true;

            for(int i = 0;i<input.Length;i++)
            {
                if(hasallnegnumbers && input[i] > 0)
                {
                    hasallnegnumbers = false;
                }
                else if(hasallnegnumbers && input[i] < 0 && maxnegsum < input[i])
                {
                    maxnegsum = input[i];
                }
                curSum += input[i];
                if(curSum < 0)
                {
                    curSum = 0;
                }
                if(maxSum < curSum)
                {
                    maxSum = curSum;
                }
            }
            var res = hasallnegnumbers ? maxnegsum : maxSum;
            Console.WriteLine($"max sum in subarray is {res}");

        }
    }
}

//Given an array of unordered positive and negative integers, find the maximum subarray sum in the array.
//For example:
//Array: { 2, -9, 5, 1, -4, 6, 0, -7, 8}
//Output:
//Maximum subarray sum is 9