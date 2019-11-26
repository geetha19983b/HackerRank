using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MarcCakeWalk
    {
        public void FindMinDist()
        {
            int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp))
      ;
            Array.Sort(calorie);

            double totalMiles = 0;
            for(int i = 0;i < calorie.Length;i++)
            {
                totalMiles += Math.Pow(2, i) * calorie[calorie.Length - i - 1];
            }
            Console.WriteLine(Convert.ToInt64(totalMiles));
        }
    }
}
