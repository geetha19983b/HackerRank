using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class SuperReducedString
    {
        public void getSuperReducedString()
        {
            string s = Console.ReadLine();

            var sb = new StringBuilder();
            sb.Append(s[0]);
            for(int i = 1;i<s.Length;i++)
            {
                if(sb.Length >0 && s[i] == sb[sb.Length - 1])
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            if (sb.Length > 0)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Empty String");
            }
        }
    }
}
