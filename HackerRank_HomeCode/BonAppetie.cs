using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BonAppetie
    {
        public void ValidateBill()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');
//no of array elements
            int n = Convert.ToInt32(nk[0]);
            //index of item which anna does not eat
            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            //bill charged by bob 
            int b = Convert.ToInt32(Console.ReadLine().Trim());

            int annaShare = 0;
            int annaItems = 0;
            for(int i = 0;i<bill.Count;i++)
            {
                if(i != k)
                {
                    annaItems += bill[i];
                }
            }
            annaShare = annaItems / 2;

            if(annaShare == b)
            {
                Console.WriteLine("Bon appetie!!");
            }
            else
            {
                Console.WriteLine(b-annaShare);
            }
        }
    }
}
