using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class EqualStacks
    {
        public void FindEqualHeight()
        {
            string[] n1N2N3 = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(n1N2N3[0]);

            int n2 = Convert.ToInt32(n1N2N3[1]);

            int n3 = Convert.ToInt32(n1N2N3[2]);

            int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp))
            ;

            int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp))
            ;

            int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp))
            ;
            int eqheight = 0;
            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();
            Stack<int> st3 = new Stack<int>();
            int st1TotalHeight = 0, st2TotalHeight = 0, st3TotalHeight = 0;
            for(int i = h1.Length -1;i >=0;i--)
            {
                st1TotalHeight += h1[i];
                st1.Push(st1TotalHeight);
            }
            for (int i = h2.Length - 1; i >= 0; i--)
            {
                st2TotalHeight += h2[i];
                st2.Push(st2TotalHeight);
            }
            for (int i = h3.Length - 1; i >= 0; i--)
            {
                st3TotalHeight += h3[i];
                st3.Push(st3TotalHeight);
            }
            while(true)
            {
                if (st1.Count == 0 || st2.Count == 0 || st3.Count == 0)
                {
                    eqheight = 0;
                    break;
                }
                st1TotalHeight = st1.Peek();
                st2TotalHeight = st2.Peek();
                st3TotalHeight = st3.Peek();

                // If sum of all three stack are equal.
                if (st1TotalHeight == st2TotalHeight && st2TotalHeight == st3TotalHeight)
                {
                    eqheight = st1TotalHeight;
                    break;
                }

                // Finding the stack with maximum sum and
                // removing its top element.
                if (st1TotalHeight >= st2TotalHeight && st1TotalHeight >= st3TotalHeight)
                    st1.Pop();
                else if (st2TotalHeight >= st1TotalHeight && st2TotalHeight >= st3TotalHeight)
                    st2.Pop();
                else if (st3TotalHeight >= st2TotalHeight && st3TotalHeight >= st1TotalHeight)
                    st3.Pop();
            }

            Console.WriteLine(eqheight);
        }
    }
}
