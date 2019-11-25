using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class TripleSum
    {
        public void FindPossibleTriplets()
        {
            try
            {
                string[] lenaLenbLenc = Console.ReadLine().Split(' ');

                int lena = Convert.ToInt32(lenaLenbLenc[0]);

                int lenb = Convert.ToInt32(lenaLenbLenc[1]);

                int lenc = Convert.ToInt32(lenaLenbLenc[2]);

                int[] arra = Array.ConvertAll(Console.ReadLine().Split(' '), arraTemp => Convert.ToInt32(arraTemp))
                ;

                int[] arrb = Array.ConvertAll(Console.ReadLine().Split(' '), arrbTemp => Convert.ToInt32(arrbTemp))
                ;

                int[] arrc = Array.ConvertAll(Console.ReadLine().Split(' '), arrcTemp => Convert.ToInt32(arrcTemp))
                ;
                long distinctTripletCount = 0;

                int[] distinctA = removeDuplicates(arra);
                int[] distinctB = removeDuplicates(arrb);
                int[] distinctC = removeDuplicates(arrc);

                Array.Sort(distinctA);
                Array.Sort(distinctB);
                Array.Sort(distinctC);

                foreach (var q in distinctB)
                {
                    long c1 = getValidIndex(distinctA, q) + 1;
                    long c3 = getValidIndex(distinctC, q) + 1;
                    distinctTripletCount += c1 * c3;
                }
                Console.WriteLine(distinctTripletCount);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private static int[] removeDuplicates(int[] a)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(var item in  a)
            {
                if(!set.Contains(item))
                {
                    set.Add(item);
                }
            }
            int len = set.Count();

            int []result= new int[len];
            int i = 0;
            foreach (var item in set)
            {
                result[i++] = item;
            }
            return result;
        }
        static int getValidIndex(int[] distinctA, int key)
        {
            int low = 0;
            int high = distinctA.Length - 1;
            int count = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (distinctA[mid] <= key)
                {
                    count = mid;
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }
            return count;

        }
    }
}
