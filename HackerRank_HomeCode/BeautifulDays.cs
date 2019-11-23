using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class BeautifulDays
    {
        public void GetNoOfBD()
        {
            string[] ijk = Console.ReadLine().Split(' ');
            
            //starting day
            int i = Convert.ToInt32(ijk[0]);
            //ending day
            int j = Convert.ToInt32(ijk[1]);
            //divisible number
            int k = Convert.ToInt32(ijk[2]);

            int bd = 0;
            for(int strt = i;strt<=j;strt++)
            {
                //var reversno = int.Parse(strt.ToString().Reverse().ToArray());
                var revserstring = new string(strt.ToString().Reverse().ToArray());
                var reversno = int.Parse(revserstring);
                var d = Math.Abs(strt - reversno) % k;
                if (d == 0)
                    bd++;

            }
            Console.WriteLine(bd);
        }
    }
}
