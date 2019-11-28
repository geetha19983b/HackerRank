using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class SelectionSort
    {
        public void Afterreqiteration()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);

            int k = Convert.ToInt32(nm[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int minimum;
            // reduces the effective size of the array by one in  each iteration.

            for (int i = 0; i < n - 1; i++)
            {
                if (i >= k)
                    break;
                // assuming the first element to be the minimum of the unsorted array .
                minimum = i;

                // gives the effective size of the unsorted  array .

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minimum])
                    {                //finds the minimum element
                        minimum = j;
                    }
                }
                // putting minimum element on its proper position.
                swap(minimum, i,arr);
            }
            Array.ForEach(arr, x => Console.Write(x + " "  ));
        }
        private void swap(int a,int b,int[] arr)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;

        }
    }
}


//void selection_sort(int A[ ], int n)
//{
//    // temporary variable to store the position of minimum element

//    int minimum;
//    // reduces the effective size of the array by one in  each iteration.

//    for (int i = 0; i < n - 1; i++)
//    {

//        // assuming the first element to be the minimum of the unsorted array .
//        minimum = i;

//        // gives the effective size of the unsorted  array .

//        for (int j = i + 1; j < n; j++)
//        {
//            if (A[j] < A[minimum])
//            {                //finds the minimum element
//                minimum = j;
//            }
//        }
//        // putting minimum element on its proper position.
//        swap(A[minimum], A[i]);
//    }
//}
