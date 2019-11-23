using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MigratoryBirds
    {
        public void FindMigBirdTypes()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            var birdtypeCounts = new int[5];

            for(int i = 0;i< arr.Count;i++)
            {
                birdtypeCounts[arr[i] - 1]++;
            }
           
                var maxBirdcount = birdtypeCounts[0];
            var maxBirdtype = 1;



            for(int i = 1;i<5;i++)
            {
               
                if (maxBirdcount < birdtypeCounts[i])
                {
                    maxBirdcount = birdtypeCounts[i];
                    maxBirdtype = i + 1;
                  
                }
                //if (maxBirdcount == birdtypeCounts[i] && i + 1 < maxBirdtype)
                //{
                //    maxBirdtype = i + 1;
                //}
            }
            Console.WriteLine(maxBirdtype);
        }
    }
}
