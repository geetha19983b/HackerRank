using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class DrawingBook
    {
        public void findMinPagesToturn()
        {
            //number of pages in book
            int n = Convert.ToInt32(Console.ReadLine());
            //target page to turn
            int p = Convert.ToInt32(Console.ReadLine());

            var minPagesToTurn = 0;

            if (p == 1 || n == p)
            {
                minPagesToTurn = 0;
                
            }
            else if(n % 2 != 0 && p == (n -1))
            {
                minPagesToTurn = 0;
                
            }
            else if(n%2 ==0) //6 5
            {
                if( p <= n /2)
                {
                    minPagesToTurn = (int)Math.Ceiling((double)(p / 2));
                }
                else
                {
                    double d = ((double)(n-p)) / 2;
                    minPagesToTurn = (int)Math.Ceiling(d);

                }
            }
            else
            {
                //n = 7 and p = 4
                //n = 7 and p = 3
                if (p == (n / 2) + 1 && n % 4 == 3)
                {
                    minPagesToTurn = (n - p) / 2;
                }
                else if (p <= ((n / 2) + 1))
                {
                    minPagesToTurn = (p / 2);
                }
                else
                {
                  
                    minPagesToTurn = (n - p) / 2;

                }
            }
            Console.WriteLine(minPagesToTurn);

        }
    }
}
