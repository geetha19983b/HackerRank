using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class TwoCharacters
    {
        public void FindMAxLength()
        {
            int l = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            //find the distinct characters in the string
            int max = 0;
            for (char c1 = 'a'; c1 <= 'z'; c1++)
            {
                for (char c2 = (char)(c1 + 1); c2 <= 'z'; c2++)
                {
                    int len = 0;
                    char prev = '\0';
                    for (int i = 0; i < s.Length; i++)
                    {
                        char next = s[i];
                        if (next == c1 || next == c2)
                        {
                            if (next != prev)
                            {
                                len++;
                                prev = next;
                            }
                            else
                            {
                                len = 0;
                                break;
                            }
                        }
                    }
                    max = Math.Max(max, len);
                }
            }

            Console.WriteLine(max);

        }
        
    }
}
