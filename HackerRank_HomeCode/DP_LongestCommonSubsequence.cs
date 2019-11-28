using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.youtube.com/watch?v=DuikFLPt8WQ
    public class DP_LongestCommonSubsequence
    {
        static int[][] dp;
        static int[][] cache;

        //recursive solution
        public static int LCSM1(char[] x,char[] y,int i,int j)
        {
            if (i <= 0 || j <= 0)
                return 0;
            if (x[i - 1] == y[j - 1])
                return 1 + LCSM1(x, y, i - 1, j - 1);
            else
                return Math.Max(LCSM1(x, y, i, j - 1), LCSM1(x, y, i - 1, j));
        }
        //DP solution 2d array
        public int LCSM2(char[] x, char[] y, int m, int n)
        {
            int[,] memo = new int[m + 1,n+1];

            for(int i = 0;i<=m;i++)
            {
                for(int j=0;j<=n;j++)
                {
                    if(i==0 || j ==0)
                    {
                        memo[i,j] = 0;
                    }
                    else if(x[i-1] ==y[j-1])
                    {
                        memo[i,j] = memo[i - 1,j - 1] + 1;

                    }
                    else
                    {
                        memo[i, j] = Math.Max(memo[i - 1,j]
                            , memo[i,j - 1]);
                    }
                }
            }
            //print memo matrix
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.Write(memo[i,j] + " ");
                }
                Console.WriteLine();
            }

                    return memo[m,n];
        }

        //optimal DP with 1d array
        public static int LCSM3(char[] x,char[] y,int m,int n)
        {
            int[] memo = new int[n + 1];

            for(int i = 1;i<=m;i++)
            {
                int prev = 0;
                for(int j=1;j<=n;j++)
                {
                    int temp = memo[j];
                    if(x[i-1] == y[j-1])
                    {
                        memo[j] = prev + 1;
                    }
                    else
                    {
                        memo[j] = Math.Max(memo[j], memo[j - 1]);
                    }
                    prev = temp;
                }
            }
            return memo[n];
        }
        public void FindTheLCS()
        {
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            string x = "JAVAAID";
            string y = "JAVAID";
            var res1 = LCSM1(x.ToCharArray(), y.ToCharArray(), x.Length, y.Length);
            Console.WriteLine(res1);
            var res2 = LCSM2(x.ToCharArray(), y.ToCharArray(), x.Length, y.Length);
            Console.WriteLine(res2);
            var res3 = LCSM3(x.ToCharArray(), y.ToCharArray(), x.Length, y.Length);
            Console.WriteLine(res3);
        }
    }
}

//answe is bottom right 6

 //    j a v a a i d
 //  0 0 0 0 0 0 0 0
 //j 0 1 1 1 1 1 1 1
 //a 0 1 2 1 2 2 2 2
 //v 0 1 2 3 3 3 3 3
 //a 0 1 2 3 4 4 4 4
 //i 0 1 2 3 4 4 5 5
 //d 0 1 2 3 4 4 5 6