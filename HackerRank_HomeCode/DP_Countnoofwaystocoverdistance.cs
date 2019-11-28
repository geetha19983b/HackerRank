using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.geeksforgeeks.org/count-number-of-ways-to-cover-a-distance/
    public class DP_Countnoofwaystocoverdistance
    {
        public void CountNoOfWays()
        {
            int dist = 4;
            int[] count = new int[dist + 1];

            // Initialize base values. There is one 
            // way to cover 0 and 1 distances  
            // and two ways to cover 2 distance  
            count[0] = 1;
            count[1] = 1;
            count[2] = 2;

            for(int i = 3;i<=dist;i++)
            {
                count[i] = count[i - 1] + count[i - 2] + count[i - 3];

            }
            Console.WriteLine($"No of ways to conver the dist of {dist} is {count[dist]}");
        }
    }
}
