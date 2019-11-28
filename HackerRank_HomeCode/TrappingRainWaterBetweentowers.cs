using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.ideserve.co.in/learn/trapping-rain-water-between-towers
//    Example:
//Input  - {1,5,2,3,1,7,2,4}
//Output - 11
    public class TrappingRainWaterBetweentowers
    {
        public void finMaxTrappedRainWater()
        {
            int[] towerHeight = { 1, 5, 2, 3, 1, 7, 2, 4 };
            int maxSeensoFar = 0;
            int[] maxSeenRight = new int[towerHeight.Length];
            int maxSeenLeft = 0;

            int rainwater = 0;

            for(int i = towerHeight.Length-1;i>=0;i--)
            {
                if(towerHeight[i] >maxSeensoFar)
                {
                    maxSeensoFar = towerHeight[i];
                    maxSeenRight[i] = maxSeensoFar;
                }
                else
                {
                    maxSeenRight[i] = maxSeensoFar;
                }
            }
            for(int i = 0;i<towerHeight.Length;i++)
            {
                rainwater = rainwater +
                    Math.Max(
                        Math.Min(maxSeenLeft, maxSeenRight[i]) - towerHeight[i], 0);
                if(towerHeight[i] > maxSeenLeft)
                {
                    maxSeenLeft = towerHeight[i];
                }
            }
            Console.WriteLine($"Max trapped rian water between towers is {rainwater}");
        }
    }
}
