using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BirthdayCake
    {
        public void ShareCake()
        {
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            var totalways_tosplit = 0;

            if(s.Count >= m)
            {
                var barsum = 0;
                //initial sum
                for(int i = 0;i<m;i++)
                {
                    barsum += s[i];
                }

                if(barsum == d)
                {
                    totalways_tosplit++;
                }

                for(int i = 0;i < s.Count - m;i++)
                {
                    barsum = barsum - s[i] + s[i + m];
                    if (barsum == d)
                    {
                        totalways_tosplit++;
                    }
                }

                Console.WriteLine(totalways_tosplit); ;


            }


        }
    }
}
