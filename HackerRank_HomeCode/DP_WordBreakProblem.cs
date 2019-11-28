using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    //https://www.ideserve.co.in/learn/word-break-problem
    public class DP_WordBreakProblem
    {
        static HashSet<String> dictionary = new HashSet<String>(new string[] { "arrays", "dynamic", "heaps", "IDeserve", "learn", "learning", "linked", "list",
                                                    "platform", "programming", "stacks", "trees" });
        public void TestWB()
        {
            if (hasValidWords("IDeservelearningplatform"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public bool hasValidWords(String words)
        {

            if (words == null || words.Length == 0)
            {
                return true;
            }
            int n = words.Length;
            bool[] validWords = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if (i + 1 < n)
                {
                    if (dictionary.Contains(words.Substring(0, i + 1)))
                    {
                        validWords[i] = true;
                    }
                }
                if (validWords[i] == true & (i == n - 1))
                {
                    return true;
                }
                if (validWords[i] == true)
                {
                    int z = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        
                        if (dictionary.Contains(words.Substring(i + 1, z)))
                        {
                            validWords[j] = true;
                        }
                        z++;
                        if (j == n - 1 && validWords[j] == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }
    }
}
