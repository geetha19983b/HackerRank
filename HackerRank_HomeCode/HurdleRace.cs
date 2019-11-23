using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class HurdleRace
    {
        public void DoseToTake()
        {
            string[] nk = Console.ReadLine().Split(' ');
            //number of hurdles
            int n = Convert.ToInt32(nk[0]);
            //dans max height he can jump
            int k = Convert.ToInt32(nk[1]);
            //height of hurdles
            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));
            var maxHurdleHeight = height.OrderByDescending(x => x).First();
            int dose = 0;
            dose = maxHurdleHeight - k;

            if (dose < 0)
            {
                dose = 0;
            }
            Console.WriteLine(dose);


        }
    }
}
