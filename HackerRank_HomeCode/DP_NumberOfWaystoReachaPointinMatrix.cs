using System;
using System.Collections.Generic;
using System.Text;

//1 2 3 4
//5 6 7 8
//9 10 11 12
//13 14 15 16

//1 1 1 1
//1 2 3 4
//1 3 6 10
//1 4 10 20
namespace HackerRank_HomeCode
{
    //https://github.com/mission-peace/interview/blob/master/src/com/interview/dynamic/NumberOfPathsInMxNMatrix.java
    //https://www.youtube.com/watch?v=GO5QHC_BmvM
    //you can move right or down
    //// A C#  program to count all possible paths 
    // from top left to bottom right 
    using System;
    public class DP_NumberOfWaystoReachaPointinMatrix
    {
        public void findNoOfWays()
        {
            int m= 3;
            int n= 3;

            int[,] count = new int[m, n];

            // Count of paths to reach any cell in 
            // first column is 1 
            for(int i = 0;i<m;i++)
            {
                count[i,0] = 1;
            }
            // Count of paths to reach any cell in 
            // first column is 1 
            for(int j = 0;j<n;j++)
            {
                count[0, j] = 1;
            }
            // Calculate count of paths for other 
            // cells in bottom-up manner using 
            // the recursive solution 

            for(int i = 1;i < m;i++)
            {
                for(int j = 1;j<n;j++)
                {
                    count[i, j] = count[i - 1, j] + count[i, j - 1];
                        //+ count[i-1,j-1] //if diagnoal movement is allowed
                }
            }
            Console.WriteLine($"no of ways to reach a point in matrix is {count[m-1,n-1]}");

        }
    }
}
