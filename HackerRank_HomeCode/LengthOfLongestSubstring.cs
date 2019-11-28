using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class LengthOfLongestSubstring
    {
        public void findMaxLength()
        {
            string s = Console.ReadLine();
            HashSet<char> chrset = new HashSet<char>();
            int maxLength = 1;
            int rollingMAx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                chrset = new HashSet<char>();
                chrset.Add(s[i]);
                maxLength = 1;
                int j = i + 1;
                while (j < s.Length)
                {

                    if (!chrset.Contains(s[j]))
                    {
                        chrset.Add(s[j]);
                        maxLength++;
                    }
                    else
                    {
                       
                        break;
                    }

                    j++;
                }

                rollingMAx = Math.Max(maxLength, rollingMAx);

            }
            Console.WriteLine(rollingMAx);

        }
    }
}
