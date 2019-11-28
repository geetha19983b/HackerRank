using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class BinarySearch_FindtheRank
    {
        public void FindTheRankOfElements()
        {
           
            int n = Convert.ToInt32(Console.ReadLine());


            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            Array.Sort<int>(arr);
            int noOfQueries = Convert.ToInt32(Console.ReadLine());
            int[] queries = new int[noOfQueries];
            for (int i = 0;i<noOfQueries;i++)
            {
                queries[i]= Convert.ToInt32(Console.ReadLine());
            }
            foreach(var item in queries)
            {
               
                var rank = binarySearch(0, n - 1, item,arr);
                if(rank != -1)
                    Console.WriteLine(rank + 1);
                else
                    Console.WriteLine(rank);
            }

        }
        private int binarySearch(int low, int high, int key,int[] a)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (a[mid] < key)
                {
                    low = mid + 1;
                }
                else if (a[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;                //key not found
        }
    }
}


//int ternary_search(int l, int r, int x)
//{
//    if (r >= l)
//    {
//        int mid1 = l + (r - l) / 3;
//        int mid2 = r - (r - l) / 3;
//        if (ar[mid1] == x)
//            return mid1;
//        if (ar[mid2] == x)
//            return mid2;
//        if (x < ar[mid1])
//            return ternary_search(l, mid1 - 1, x);
//        else if (x > ar[mid2])
//            return ternary_search(mid2 + 1, r, x);
//        else
//            return ternary_search(mid1 + 1, mid2 - 1, x);

//    }
//    return -1;
//}