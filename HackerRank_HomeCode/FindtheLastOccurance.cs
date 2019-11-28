using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class FindtheLastOccurance
    {
        public void FindLastIndex()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int lastocc = 0;
            for (int i = 0; i < n; i++)
            {
                if (c[i] ==m)
                {
                    lastocc = i + 1;
                }
            }
            if(lastocc ==0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(lastocc);
            }
        }
    }
}


//int binarySearch(int low, int high, int key)
//{
//    while (low <= high)
//    {
//        int mid = (low + high) / 2;
//        if (a[mid] < key)
//        {
//            low = mid + 1;
//        }
//        else if (a[mid] > key)
//        {
//            high = mid - 1;
//        }
//        else
//        {
//            return mid;
//        }
//    }
//    return -1;                //key not found
//}