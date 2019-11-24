using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class FlatLandAndSpace
    {
        public void FindFarthest()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;

            int[] flatlandarr = Enumerable.Range(0, n).ToArray();

            int[] onlyflatland = flatlandarr.Except(c).ToArray();
            int result = 0;
            //Array.ForEach(onlyflatland, x => Console.WriteLine(x));
            Dictionary<int, int> dist = new Dictionary<int, int>();
            if(onlyflatland.Any())
            {
                for (int i = 0; i < onlyflatland.Length; i++)
                {
                    int min = 0;
                    foreach (var ss in c)
                    {
                        if (min == 0)
                        {
                            min = Math.Abs(onlyflatland[i] - ss);
                         }
                        else if(min > Math.Abs(onlyflatland[i] - ss))
                        {
                            min = Math.Abs(onlyflatland[i] - ss);
                        }
                    }
                    dist.Add(onlyflatland[i], min);
                }
                //foreach(var item in dist)
                //{
                //    Console.Write(item.Key + " ");
                //    Console.Write(item.Value);
                //    Console.WriteLine();

                //}
                result = dist.FirstOrDefault(x => x.Value == dist.Values.Max()).Value;
            }
            

            Console.WriteLine(result);

        }

    }
}
