using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class HackerRankInaString
    {
        public void IsHRPResent()
        {
            string s = Console.ReadLine();
            string pattern = "hackerrank";
            int pindex = 0;
            string result = "NO";
            for(int i = 0;i<s.Length;i++)
            {
                if(s[i] == pattern[pindex])
                {
                    pindex++;
                }
                if (pindex == 10)
                {
                    result = "YES";
                    break;
                }
                
            }
            Console.WriteLine(result);
            

        }
    }
}
