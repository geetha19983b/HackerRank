using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class GreedyFlorist
    {
        public void getMinCost()
        {
            
           string[] nk = Console.ReadLine().Split(' ');
            //number of flowers
            int n = Convert.ToInt32(nk[0]);
            //no of friends
            int k = Convert.ToInt32(nk[1]);
            //cost of each flower
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int[] purchases = new int[k];
            int minimumCost = 0;

            int[] costdescnd=c.OrderByDescending(x => x).ToArray();

            for(int i = 0;i <n;i++)
            {
                minimumCost += costdescnd[i] * (purchases[i % k] + 1);
                purchases[i % k]++;
            }
            Console.WriteLine(minimumCost);
        }
    }
}
