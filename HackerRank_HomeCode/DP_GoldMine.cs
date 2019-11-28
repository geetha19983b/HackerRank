using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.geeksforgeeks.org/gold-mine-problem/
    public class DP_GoldMine
    {
        public void getMaxGold()
        {
            int[,] gold = new int[,]{{1, 3, 1, 5},
                                {2, 2, 4, 1},
                                {5, 0, 2, 3},
                                {0, 6, 1, 2}
                                };
            int m = 4, n = 4;


            // Returns maximum amount of gold that  
            // can be collected when journey started 
            // from first column and moves allowed are  
            // right, right-up and right-down  

            // Create a table for storing intermediate  
            // results and initialize all cells to 0.  
            // The first row of goldMineTable gives 
            // the maximum gold that the miner  
            // can collect when starts that row  
            int[,] goldTable = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    goldTable[i, j] = 0;

            for (int col = n - 1; col >= 0; col--)
            {
                for (int row = 0; row < m; row++)
                {
                    // Gold collected on going to  
                    // the cell on the right(->)  
                    int right = (col == n - 1) ? 0 :
                                goldTable[row, col + 1];

                    // Gold collected on going to  
                    // the cell to right up (/)  
                    int right_up = (row == 0 || col == n - 1)
                                ? 0 : goldTable[row - 1, col + 1];

                    // Gold collected on going  
                    // to the cell to right down (\)  
                    int right_down = (row == m - 1 || col == n - 1)
                                    ? 0 : goldTable[row + 1, col + 1];

                    // Max gold collected from taking  
                    // either of the above 3 paths  
                    goldTable[row, col] = gold[row, col] +
                                    Math.Max(right, Math.Max(right_up,
                                                        right_down));
                }
            }
            //the max gold collected will be the max value in the first
            //column of all the rows
            int res = goldTable[0, 0];
            for(int i = 1;i<m;i++)
            {
                res = Math.Max(res, goldTable[i, 0]);
            }
            Console.WriteLine($"Max gold collected is {res}");

        }
    }
}

//first column of all the rows will contain the max gold

//1 3 3
//2 1 4
//0 6 4

//7 6 3
//12 5 4
//10 10 4

//op is 16