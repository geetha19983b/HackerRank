using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //There are a row of n houses, each house can be painted with one of the three colors: red, blue or green. 
    //The cost of painting each house with a certain color is different. You have to paint all the houses such 
    //that no two adjacent houses have the same color.

    //The cost of painting each house with a certain color is represented by a n x 3 cost matrix. For example, 
    //costs[0][0] is the cost of painting house 0 with color red; costs[1][2] is the cost of painting house 1 
    //with color green, and so on... Find the minimum cost to paint all houses.

    //Note:
    //All costs are positive integers.
    //o/p 2+ 5 + 3 =10
    public class DP_PaintHouse
    {
        public void MinCostToPaintHouse()
        {
            int mincost = 0;
            int[,] cost = new int[3, 3]
            {
                { 17,2,17},
                {16,16,5 },
                {14,3,9}
            };

            if (cost == null || cost.Length == 0)
            {
                Console.WriteLine($"Min cost to paint the houses {mincost}");
                return;
            }
            int rowsize = cost.GetLength(0);
            for (int i = 1; i < rowsize; i++)
            {
                cost[i, 0] += Math.Min(cost[i - 1, 1], cost[i - 1, 2]);
                cost[i,1] += Math.Min(cost[i - 1, 0], cost[i - 1, 2]);
                cost[i, 2] += Math.Min(cost[i - 1, 1], cost[i - 1, 0]);

            }
            mincost = Math.Min(Math.Min(cost[rowsize - 1, 0], cost[rowsize -1, 1]), cost[rowsize - 1, 2]);
            Console.WriteLine($"Min cost to paint the houses {mincost}");
        }
    }
}
