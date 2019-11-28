﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class DynamicProgramming_MinCost
    {
        public void FindMinCost()
        {
            int[,] cost = { { 1,2,3},
                    {4,8,2 },
            {1,5,3 }};

            Console.WriteLine(minCost(cost,2,2));


        }
        private static int min(int x,int y,int z)
        {
            if (x < y)
                return (x < z) ? x : z;
            else
                return (y < z) ? y : z;
        }
        private static int minCost(int[,] cost,int m,int n)
        {
            int i, j;
            int[,] tc = new int[m + 1, n + 1];
            tc[0, 0] = cost[0, 0];
            //initialize first column
            for(i = 1;i<=m;i++)
            {
                tc[i, 0] = tc[i - 1, 0] + cost[i, 0];
            }
            for(j = 1;j<=n;j++)
            {
                tc[0, j] = tc[0, j - 1] + cost[0, j];
            }
            //construct rest of the array 
            for(i = 1;i<=m;i++)
            {
                for(j=1;j<=n;j++)
                {
                    tc[i, j] = min(tc[i - 1, j - 1], tc[i - 1, j], tc[i, j - 1]) +
                        cost[i, j];
                }
            }
            return tc[m, n];
        }
    }
}
