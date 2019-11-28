using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://github.com/mission-peace/interview/blob/master/src/com/interview/dynamic/SubsetSum.java
    /*

 * Given an array of non negative numbers and a total, is there subset of numbers in this array which adds up
 * to given total. Another variation is given an array is it possible to split it up into 2 equal
 * sum partitions. Partition need not be equal sized. Just equal sum.
 * Youtube video - https://youtu.be/s6FhG--P7z0
 */
    public class DP_subsetSum
    {
        public void checkIfSubsetSum()
        {
            int[] arr1 = { 2, 3, 7, 8 ,10};
            var res = subsetSum(arr1, 9);
            Console.WriteLine($"subset values is present is {res}");
        }
        public bool subsetSum(int[] input, int total)
        {

            bool[,] T = new bool[input.Length + 1, total + 1];
            //optional
            for(int i = 0;i <=total;i++)
            {
                T[0, i] = false;
            }
            //optional
            for (int i = 0; i <= input.Length; i++)
            {
                T[i, 0] = true;
            }

            for (int i = 1; i <= input.Length; i++)
            {
                for (int j = 1; j <= total; j++)
                {
                    if (j - input[i - 1] >= 0)
                    {
                        T[i,j] = T[i - 1,j] || T[i - 1,j - input[i - 1]];
                    }
                    else
                    {
                        T[i,j] = T[i - 1,j];
                    }
                }
            }
            for (int i = 0; i <= input.Length; i++)
            {
                for (int j = 0; j <= total; j++)
                {
                    Console.Write(T[i,j]  + " ");
                }
                Console.WriteLine();

            }

                return T[input.Length,total];

        }
    }
}


//sub set  sum problem
//--> total sum  | items in the matrix
//   0 1 2 3 4 5 6 7 8 9 10 11 
//   T f f f f f f f f f f f
//2  T F T F f f f f f f f f
//3  T f t t f t f f f f f f
//7  T f t t f t f t f t t f
//8  T f t t f t f t t t t t
//10 T f t t f t f t t t t t

//fill t/f based on if we can make the sum using
//the item in y axis
//for sum 1 using only item 2 we cannot reach

//for sum 3 put the top row value for items less then 3
//for 3value and 3 (sum) if top row is false
//go three steps backwards and take that value

//check the last row and last column for the answe

    //to find the numbers contributing to sum
    //check the bottom true its coming due to the top row true so the top row number
    // 8 should be considred now subtract 11-8 3 go one row abouve 8 and go to 3 total colum
    // that colum true is coming from the top  row true so 3 is considred
    //3 -3 = 0 stop the processing