using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class RecursivePattern
    {
        public void TestRecursivePattern()
        {
            int n = 16;

            printPattern(n);
        }
        public  void printPattern(int n)
        {

            // Base case (When n becomes 0 or  
            // negative) 
            if (n == 0 || n < 0)
            {

                Console.Write(n + " ");

                return;
            }

            // First print decreasing order 
            Console.Write(n + " ");

            printPattern(n - 5);

            // Then print increasing order 
            Console.Write(n + " ");
        }

    }
}
