using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class OrgnzContainerOfBalls
    {
        public void organizingContainers()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] container = new int[n][];
            List<int> rowsumlst = new List<int>();
            List<int> colsumlst = new List<int>();
            for (int i = 0; i < n; i++)
            {
                container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
            }
            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                int colSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += container[i][j];
                    colSum += container[j][i];
                }
                rowsumlst.Add(rowSum);
                colsumlst.Add(colSum);
                //if (colSum != rowSum)
                //{
                //    Console.WriteLine("Impossible");
                //    break;
                //}
                //if(colSum == rowSum)
                //{
                //    Console.WriteLine("Possible");
                //    break;
                //}
            }
            rowsumlst.RemoveAll(x => colsumlst.Contains(x));

            if(rowsumlst.Count == 0)
            {
                Console.WriteLine("Possibe");
            }
            else
            {
                Console.WriteLine("Impossible");
            }



        }
    }
}
