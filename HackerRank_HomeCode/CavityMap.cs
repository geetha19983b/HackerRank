using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class CavityMap
    {
        public void ReplaceCavity()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            for(var row = 1; row < grid.Length - 1;row++)
            {
                for(var column = 1;column < grid.Length - 1;column++)
                {
                    if(grid[row][column] > grid[row - 1][column]
                        && grid[row][column] > grid[row + 1][column]
                        && grid[row][column] > grid[row][column -1]
                        && grid[row][column] > grid[row][column+1])
                    {
                        var removeCavity = grid[row].Remove(column, 1).Insert(column, "X");
                        grid[row] = removeCavity;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(grid[i]);
            }
        }
    }
}
