using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class ElectronicsShop
    {
        public void GetMaxPurchAmt()
        {

            string[] bnm = Console.ReadLine().Split(' ');
            //budget

            int b = Convert.ToInt32(bnm[0]);
            //number of keybords
            int n = Convert.ToInt32(bnm[1]);
            //no of drivers
            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            var sortedKeybrods = keyboards.OrderByDescending(x => x).ToArray();
            var sorteddrives = from driver in drives
                               orderby driver ascending
                               select driver;
            var maxSpendAmt = -1;
            foreach(var key in sortedKeybrods)
            {
                foreach(var drv in sorteddrives)
                {
                    if(key + drv <= b)
                    {
                        if(key + drv > maxSpendAmt)
                        {
                            maxSpendAmt = (key + drv);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(maxSpendAmt);

        
        }
    }
}
