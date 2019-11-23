using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class TwoStrings
    {
        public void IsPresent()
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            Dictionary<char, int> dictlist = new Dictionary<char, int>();
            string result = "No";
            if(s1.Length < s2.Length)
            {
                dictlist=AddCharsToDict(s1);
                foreach(char c in s2)
                {
                    if(dictlist.ContainsKey(c))
                    {
                        result = "Yes";
                        break;
                    }
                }
            }
            else
            {
                dictlist=AddCharsToDict(s2);
                foreach (char c in s1)
                {
                    if (dictlist.ContainsKey(c))
                    {
                        result = "Yes";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
        
        private  Dictionary<char, int> AddCharsToDict(string s)
        {
            Dictionary<char, int> dictlist = new Dictionary<char, int>();
            foreach(char c in s.ToCharArray())
            {
                if(dictlist.ContainsKey(c))
                {
                    dictlist[c]++;
                }
                else
                {
                    dictlist.Add(c, 1);
                }
            }
            return dictlist;
        }
    }
}
