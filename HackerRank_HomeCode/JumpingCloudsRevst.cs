using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class JumpingCloudsRevst
    {
        public void CalcualteEnergyRemin()
        {
            string[] nk = Console.ReadLine().Split(' ');
            //no of clouds
            int n = Convert.ToInt32(nk[0]);
            //jump size
            int k = Convert.ToInt32(nk[1]);
            //clouds 
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            var totalEnergyRemaining = 100;
            var currentCloud = 0;

            while(true)
            {
                currentCloud = (currentCloud + k) % n;

                if(c[currentCloud] == 1)
                {
                    totalEnergyRemaining -= 3;
                }
                else
                {
                    totalEnergyRemaining -= 1;
                }

                if (currentCloud == 0)
                    break;
            }
            Console.WriteLine(totalEnergyRemaining);
        }
    }
}
