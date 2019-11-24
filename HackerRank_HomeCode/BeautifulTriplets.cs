using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BeautifulTriplets
    {
        public void FindBt()
        {
            string[] nd = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;

            var hset = new HashSet<int>(arr);

            int count = 0;
            List<string> triplets = new List<string>();
            foreach(var item in hset)
            {
                if(hset.Contains(item + d) && hset.Contains(item + 2 * d))
                {
                    int secnd = item + d;
                    int thrid = item + 2 * d;
                    triplets.Add(item + "," + secnd + "," + thrid);
                    count++;
                }
            }
            Console.WriteLine(count);
            triplets.ForEach(x => Console.WriteLine(x));
        }
    }
}
