using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class CamelCase
    {
        public void NoofWords()
        {
            string s = Console.ReadLine();
            int wordCount = 0;
            if (s.Length > 0)
            {
                wordCount = 1;
                for (int i = 1; i < s.Length; i++)
                {
                    if (char.IsUpper(s[i]))
                    {
                        wordCount++;
                    }
                }
            }
            Console.WriteLine(wordCount);

        }
    }
}
