using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class BestTimetoBuyandSell
    {
        public void findMaxProfit()
        {
            int[] prices = Console.ReadLine().
                                    TrimEnd().Split(' ').
                                ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();

            int profit = 0;

            for(int i = 0;i<prices.Length;i++)
            {
                var min = prices[i];
                for(int j = i+1;j< prices.Length;j++)
                {
                    if(prices[j] >min)
                    {
                        profit = Math.Max(prices[j] - min, profit);
                    }
                }
            }
            Console.WriteLine(profit);
        }
    }
}
