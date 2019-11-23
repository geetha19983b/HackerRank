using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class Utopiantree
    {
        public void FindFinalHeight()
        {
            //no of cycles
            int n = Convert.ToInt32(Console.ReadLine());
            bool isSpring = true;
           
            int finalHeight = 1;
            while (n > 0)
            {
                if(isSpring)
                {
                    finalHeight *= 2;
                    isSpring = false;
                }
                else
                {
                    finalHeight++;
                    isSpring = true;
                }
                n--;
            }
            Console.WriteLine(finalHeight);

        }
    }
}
