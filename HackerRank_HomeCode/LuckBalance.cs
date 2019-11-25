using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class LuckBalance
    {
        public void findLuckBalance()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            //max imp contenst she can loose
            int k = Convert.ToInt32(nk[1]);

            int[][] contests = new int[n][];

            for (int i = 0; i < n; i++)
            {
                contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
            }

            int luckbalance = 0;
            //build list of important contest
            List<int> impcontest = new List<int>();
            for(int i = 0;i <n;i++)
            {
                if(contests[i][1] == 1)
                {
                    impcontest.Add(contests[i][0]);
                }
                else
                {
                    luckbalance += contests[i][0];
                }
            }

            var impcontestDesc = impcontest.OrderByDescending(x => x).ToList();

            for(int i = 0; i< impcontestDesc.Count();i++)
            {
                //loose all important contest if its less than the threshold k
                if(i < k)
                {
                    luckbalance += impcontestDesc[i];
                }
                else
                {
                    luckbalance -= impcontestDesc[i];
                }
            }

            Console.WriteLine(luckbalance);
          




        }
    }
}
