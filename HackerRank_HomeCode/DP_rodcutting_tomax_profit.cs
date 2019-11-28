using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class DP_rodcutting_tomax_profit
    {
        public void findMaxProfit()
        {
            int maxlenofrod = 5;
            int[] rod_len = { 1, 2, 3, 4 };
            int[] len_prices = { 2, 5, 7, 8 };

            int[,] t = new int[rod_len.Length + 1, maxlenofrod + 1];
            for (int i = 0; i < rod_len.Length + 1; i++)
            {
                for (int j = 0; j <= maxlenofrod; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        t[i, j] = 0;
                    }
                }
            }

            for (int i = 1; i < rod_len.Length + 1; i++)
            {
                for (int j = 1; j <= maxlenofrod; j++)
                {
                    var rodlen = rod_len[i - 1];
                    if (rodlen <= j && j >= 1 && i >= 1)
                    {
                        
                        t[i, j] = Math.Max(t[i - 1, j], len_prices[i - 1] + t[i, (j - rodlen)]);
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }

            for (int i = 0; i < rod_len.Length + 1; i++)
            {
                for (int j = 0; j <= maxlenofrod; j++)
                {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Max profit made is {t[rod_len.Length , maxlenofrod ]}");

        }
    }
}

//len 	1 2 3 4
//PRices  2 5 7 8
//-->total len
//	 0 1 2 3 4  5
//   0 0 0 0 0 0  0	 
//(2)1 0 2 4 6 8  10
//(5)2 0 2 5 7 10 12
//(7)3 0 2 5 7 10 12
//(8)4 0 2 5 7 10 12

//to fill(2nd row 3rd column)
//rod of length 1 and 2 total leng is 3
//then u can take 6 or go back 2 placed 2+5

//if(j>=1)
//t[i, j] = max(t[i - 1, j], val[i - 1] + t[i, j - i]
// else
//t[i, j] = t[i - 1, j]