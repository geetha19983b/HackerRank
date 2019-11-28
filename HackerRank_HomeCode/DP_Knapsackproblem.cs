using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class DP_Knapsackproblem
    {
        public void FindMaxValueItems()
        {
            int[] val = { 1, 4, 5, 7 };
            int[] wt = { 1, 3, 4, 6 };

            int r = bottomUpDP(val, wt, 7);
            Console.WriteLine($"Max valued item which can be carried with capacity of bag as 7 is {r}");
        }
        public int bottomUpDP(int[] val, int[] wt, int W)
        {
            int[,] K = new int[val.Length + 1, W + 1];
            for (int i = 0; i <= val.Length; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        K[i, j] = 0;
                        continue;
                    }
                    if (j - wt[i - 1] >= 0)
                    {
                        K[i, j] = Math.Max(K[i - 1, j], K[i - 1, j - wt[i - 1]] + val[i - 1]);
                    }
                    else
                    {
                        K[i, j] = K[i - 1, j];
                    }
                }
            }
            return K[val.Length,W];
        }
    }
}


/* 0/1 Knapsack Problem - Given items of certain weights/values and maximum allowed weight
* how to pick items to pick items from this set to maximize sum of value of items such that
* sum of weights is less than or equal to maximum allowed weight.
*
* Time complexity - O(W* total items)
*
* Youtube link
* Topdown DP - https://youtu.be/149WSzQ4E1g
* Bottomup DP - https://youtu.be/8LusJS5-AGo
*
* References -
* http://www.geeksforgeeks.org/dynamic-programming-set-10-0-1-knapsack-problem/
* https://en.wikipedia.org/wiki/Knapsack_problem
//*/
//capcity
//val wt   0 1 2 3 4 5 6 7
//(1) 1    0 1 1 1 1 1 1 1
//(4) 3    0 1 1 4 5 5 5 5
//(5) 4    0 1 1 4 5 6 6  9
//(7) 5    0 1 1 4 5 7 8 9

//total capcity of knapscak is 7
//wt val
//1 1
//3 4
//4 5
//6 7
//row[3, 7] =max(valof picking that item + row[2, 7 - 4],5)

//i => row j => col

//if(j<wt[i])
//t[i][j] = t[i - 1][j]
//else
//   t[i][j]=max(va[i]+t[i - 1][j - wt[i]],
//               t[i - 1][j)