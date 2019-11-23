using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class ViralAdvertsing
    {
        public void GetCumulativeLikeCount()
        {
            //number of days
            int n = Convert.ToInt32(Console.ReadLine());
            var totalLikes = 0d;
            var adshared = 5.0;

            while(n > 0)
            {
                totalLikes += Math.Floor(adshared / 2);
                adshared = Math.Floor(adshared / 2) * 3;
                n--;
            }

            Console.WriteLine(Convert.ToInt32(totalLikes));
        }
    }
}
