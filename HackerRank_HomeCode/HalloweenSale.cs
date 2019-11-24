using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class HalloweenSale
    {
        public void FindNoOfItems()
        {
            string[] pdms = Console.ReadLine().Split(' ');
            int count = 0;
            int sum = 0;
            //starting price
            int p = Convert.ToInt32(pdms[0]);
            //amount to reduce
            int d = Convert.ToInt32(pdms[1]);
            //max red amount
            int m = Convert.ToInt32(pdms[2]);
            //total amount 
            int s = Convert.ToInt32(pdms[3]);
            sum = p;
            if ( p <s)
            {
                
                count++;
            }
            while(sum <= s)
            {
                if (p - d > m)
                {
                    p = p - d;
                }
                else if (p - d == m)
                {
                    p = m;
                }
                else
                {
                    p = m;
                }
                sum = sum + p;
                Console.WriteLine("sum + p " + sum +"+" + p);
                if (sum <= s)
                    count++;
            }
            Console.WriteLine(count);

        }
    }
}
