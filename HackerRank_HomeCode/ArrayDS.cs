using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class ArrayDS
    {
        public void RevArray()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
      ;
            int len = arr.Length - 1;
            for(int i = 0;i<=len/2;i++)
            {
                int temp = arr[i];
                arr[i] = arr[len - i];
                arr[len - i] = temp;
            }
            Array.ForEach(arr, x => Console.Write(x));
        }
    }
}
