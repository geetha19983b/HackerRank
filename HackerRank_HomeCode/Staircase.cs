using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Staircase
    {
        public void PrintStaircase()
        {
            Console.WriteLine("Print the height of the staircase");
            int n = Convert.ToInt32(Console.ReadLine());
            int space = 0;
            for(int i = 0;i <n;i++)
            {
                space = n - i -1 ;
                if (i != n - 1)
                {
                    Console.Write("".PadLeft(space));
                }
                for (int j = 0; j <= i; j++)
                {
                   
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
