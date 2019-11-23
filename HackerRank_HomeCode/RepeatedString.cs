using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class RepeatedString
    {
        public void CounttheA()
        {
            string s = Console.ReadLine();
            //no of repetation of the string
            long n = Convert.ToInt64(Console.ReadLine());
            //abc repeat 10 times  10/3 = 3 whole 1 offset repet
            

            //count the a in the string

            long countA = (from c in s.ToCharArray()
                          where c == 'a'
                          select c).Count();

            var wholepossiblerepet = n / (s.Length);
            countA = Convert.ToInt64(countA * wholepossiblerepet);

            var offsetrept = n % (s.Length);

            for(int i = 0;i<offsetrept;i++)
            {
                if (s[i] == 'a')
                    countA++;
            }
            Console.WriteLine(countA);
        }
    }
}
