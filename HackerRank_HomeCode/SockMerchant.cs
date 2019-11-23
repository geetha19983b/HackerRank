using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class SockMerchant
    {
        public void FindNoOfMatchingPairs()
        {
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            var pairsFound = 0;

            var stocksDict = new Dictionary<int, int>();

            foreach(var sock in ar)
            {
                if(stocksDict.ContainsKey(sock))
                {
                    pairsFound++;
                    stocksDict.Remove(sock);
                }
                else
                {
                    stocksDict.Add(sock,1);
                }
            }
            Console.WriteLine(pairsFound);
        }
    }
}
