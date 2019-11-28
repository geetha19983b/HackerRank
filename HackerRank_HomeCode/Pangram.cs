using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class Pangram
    {
        public void IsStringPangram()
        {
            string s = Console.ReadLine();
            
            string result = "not pangram";
            HashSet<char> set = new HashSet<char>();

            
            foreach(char c in s.ToUpper().ToCharArray())
            {
                
                if(((int)c >= 65 && (int)c<=90)
                    ||
                         ((int)c >= 97 && (int)c <= 122))
                {
                    set.Add(c);
                }
            }
            if(set.Count == 26)
            {
                result = "pangram";
            }
            
            Console.WriteLine(result);
        }
    }
}
