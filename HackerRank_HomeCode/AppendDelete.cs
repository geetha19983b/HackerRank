using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class AppendDelete
    {
        public void IsPossible()
        {
            //first string
            string s = Console.ReadLine();
            //second string
            string t = Console.ReadLine();
            //no of operation in which s must be made same as t
            int k = Convert.ToInt32(Console.ReadLine());
            string result = "ERROR";

            //aba aba k =6
            if (s.Equals(t))
            {
                result = (k >= s.Length * 2 || k % 2 == 0) ? "YES" : "NO";
            }
            else
            {
                int matchingCharacters = 0;

                for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
                {
                    if (s[i] != t[i])
                    {
                        break;
                    }
                    matchingCharacters++;
                }
                int nms = s.Length - matchingCharacters;
                int nmt = t.Length - matchingCharacters;

                bool condA = nms + nmt == k;
                //aaaaaaaaaa = 10
                //aaaaa = 5
                bool condB = (nms + nmt < k && (nms + nmt - k) % 2 == 0);
                bool condC = s.Length + t.Length <= k;

                result = (condA || condB || condC) ? "YES" : "NO";

               

            }
            Console.WriteLine(result);
        }
    }
}
