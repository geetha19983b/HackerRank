using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class CountingValleys
    {
        public void getValleyCounts()
        {
            //nuumber of steps
            int n = Convert.ToInt32(Console.ReadLine());

            //steps details U uphill or downhiss
            string s = Console.ReadLine();

            var seaLevel = 0;
            var valleyCount = 0;

            var garryStepArray = s.ToCharArray();

            var isValley = false;

            for(var i = 0;i < n;i++)
            {
                if(garryStepArray[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if(!isValley && seaLevel < 0)
                {
                    isValley = true;
                }
                if(isValley && seaLevel == 0)
                {
                    valleyCount++;
                    isValley = false;
                }

            }
            Console.WriteLine(valleyCount);

        }
    }
}
