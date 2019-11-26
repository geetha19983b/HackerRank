using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class JimandOrders
    {
        public void DisplayTheOrderDelivery()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] orders = new int[n][];

            for (int i = 0; i < n; i++)
            {
                orders[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
            }

            Dictionary<int, int> dictOrder = new Dictionary<int, int>();

            for(int i = 0;i<orders.Length;i++)
            {
                var preptime = orders[i][0] + orders[i][1];
                if(!dictOrder.ContainsKey(i+1))
                {
                    dictOrder.Add((i + 1), preptime);
                }
            }
            int[] orderdelvseq = dictOrder.OrderBy(x => x.Value).Select(x => x.Key).ToArray();
            Array.ForEach(orderdelvseq, x => Console.WriteLine(x));

        }
    }
}
