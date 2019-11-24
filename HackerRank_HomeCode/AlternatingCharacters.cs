using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class AlternatingCharacters
    {
        public void findNoOfDel()
        {
            string s = Console.ReadLine();

            int deletions = 0;
            int currentCount = 1;

            for(int i = 1;i<s.Length;i++)
            {
                if(s[i] != s[i-1])
                {
                    deletions += currentCount - 1;
                    currentCount = 1;
                    continue;
                }
                currentCount++;
            }
            deletions += currentCount - 1;
            Console.WriteLine(deletions);

        }
    }
}
