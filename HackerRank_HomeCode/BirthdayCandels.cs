using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BirthdayCandels
    {
        public void FindNoOfCandels()
        {
            Console.WriteLine("Enter the height of the candels sep by spaces");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int maxHeight = ar[0];
            int maxCandels = 1;
            for(int i = 1;i< ar.Length;i++)
            {
               
                if(ar[i] == maxHeight)
                {
                    maxCandels++;
                }
                if (maxHeight < ar[i])
                {
                    maxHeight = ar[i];
                    maxCandels = 1;
                }
            }
            Console.WriteLine("Max candels which can be blown out " + maxCandels);
        }
            
    }
}
