using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class CountTriplets
    {
        public void CountOfTriplets()
        {

            string[] nr = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nr[0]);

            long r = Convert.ToInt64(nr[1]);
            long count = 0;
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
            //List<string> triplets = new List<string>();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    for (int j = i + 1; j < arr.Count; j++)
            //    {
            //        for (int k = j + 1; k < arr.Count; k++)
            //        {
            //            if ((arr[i] * r == arr[j]) && (arr[j] * r == arr[k]))
            //            {
            //                triplets.Add(i + " " + j + " " + k);
            //            }
            //        }
            //    }
            //}

            //triplets.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine(triplets.Count());

            Dictionary<long, long> dict = new Dictionary<long, long>();

            foreach(var item in arr)
            {
                if(dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            //arr.ForEach(x =>
            //{
            //    if (dict.ContainsKey(x))
            //    {
            //        dict[x]++;
            //    }
            //    else
            //    {
            //        dict.Add([x], 1);
            //    }
            //});
            foreach (long currentKey in dict.Keys)
            {
                if (currentKey == 1 || currentKey % r ==0)
                {
                    long previousKey = currentKey / r;
                    long nextKey = currentKey * r;
                    long previousCount = dict.ContainsKey(previousKey) ? dict[previousKey] : 0;
                    long nextCount = dict.ContainsKey(nextKey) ? dict[nextKey] : 0;
                    if (previousCount != 0 && nextCount != 0)
                    {
                        count += previousCount * nextCount + dict[currentKey] - 1;
                    }
                }
            }
            Console.WriteLine(count); 

        }
    }
}
