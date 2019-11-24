using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MakingAnagrams
    {
        public void NoOfDeletion()
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            Dictionary<char, int> s1FreqMap = new Dictionary<char, int>();
            Dictionary<char, int> s2FreqMap = new Dictionary<char, int>();

            for(int i = 'a';i<='z';i++)
            {
                s1FreqMap.Add((char)i, 0);
                s2FreqMap.Add((char)i, 0);
            }

            foreach(char c in a.ToCharArray())
            {
                if(s1FreqMap.ContainsKey(c))
                {
                    s1FreqMap[c]++;
                }
            }

            foreach (char c in b.ToCharArray())
            {
                if (s2FreqMap.ContainsKey(c))
                {
                    s2FreqMap[c]++;
                }
            }
            int deletions = 0;
            foreach(char c in s1FreqMap.Keys)
            {
                int f1 = s1FreqMap[c];
                int f2 = s2FreqMap[c];

                deletions += Math.Abs(f1 - f2);
            }
            Console.WriteLine(deletions);
        }
    }
}
