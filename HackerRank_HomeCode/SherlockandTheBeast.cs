using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class SherlockandTheBeast
    {
        public void FindtheDecentNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            StringBuilder sb = new StringBuilder();
            int fives = 0;
            int threes = 0;

            while (n > 0)
            {
                if(n%3 == 0)
                {
                    fives++;
                    n = n - 3;
                }
                else if(n% 5 == 0)
                {
                    threes++;
                    n = n - 5;
                }
                else
                {
                    fives++;
                    n = n - 3;
                }
            }
            if(n < 0)
            {
                sb.Append("-1");
            }
            else
            {
                for(int i = 0;i<fives;i++)
                {
                    sb.Append("555");

                }
                for(int i = 0;i<threes;i++)
                {
                    sb.Append("33333");
                }

            }
            Console.WriteLine(sb);
        }
    }
}
