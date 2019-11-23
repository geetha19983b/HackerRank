using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class CircularArrayrotate
    {
        public void GetItemsAfterRotation()
        {
            string[] nkq = Console.ReadLine().Split(' ');
            //no of elem in array

            int n = Convert.ToInt32(nkq[0]);
            //no of rotation
            int k = Convert.ToInt32(nkq[1]);
            //queries of the indices
            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }
            //int[] a = new int[] { 1, 2, 3 };
            ////Array.Reverse<int>(ar);
            int[] aar = new int[a.Length];
            //int k = 3;
            //if (k <= 0 || k > a.Length - 1)
            //{
            //    aar = a;
            //}
            //else
            //{
            //    aar =a.Skip(k-1)            // Start with the last elements
            //             .Concat(a.Take(k-1)) // Then the first elements
            //             .ToArray();
            //}
            //Console.WriteLine("rortated array ");
            //Array.ForEach(aar, x => Console.Write(x));
            //int[] op = new int[queries.Length];
            //int idx = 0;
            //foreach(var query in queries)
            //{
            //    op[idx] = aar[query];
            //    idx++;
            //}

            //Console.WriteLine();
            //Console.WriteLine("queries pos");
            //Array.ForEach(op, x => Console.Write(x));

            for (int i = 0; i < a.Length; i++)
            {
                aar[(i + k) % (a.Length)] = a[i];
            }
            Console.WriteLine("rortated array ");
            Array.ForEach(aar, x => Console.Write(x));

            int[] op = new int[queries.Length];
            int idx = 0;
            foreach (var query in queries)
            {
                op[idx] = aar[query];
                idx++;
            }

            Console.WriteLine();
            Console.WriteLine("queries pos");
            Array.ForEach(op, x => Console.Write(x));

        }
    }
}
