using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MaximumElementInStack
    {
        public void StackOps()
        {
            //enter no of queries
            int n = Convert.ToInt32(Console.ReadLine());

            Stack<int> mainStack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            maxStack.Push(Int16.MinValue);
            for (int i = 0; i < n; i++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int op = Convert.ToInt32(nk[0]);
                int opvalue = 0;
                if (nk.Length > 1)
                {
                    opvalue = Convert.ToInt32(nk[1]);
                }
                
                //int opvalue = Convert.ToInt32(nk[1]);
                //int op = Convert.ToInt32(Console.Read());
                switch (op)
                {
                    //push
                    case 1:
                        int item = opvalue;
                        mainStack.Push(item);
                        int maxElemtillnow = maxStack.Peek();
                        if (maxElemtillnow < item)
                        {
                            maxStack.Push(item);

                        }
                        else
                        {
                            maxStack.Push(maxElemtillnow);
                        }
                        break;
                    //delete 
                    case 2:
                        mainStack.Pop();
                        maxStack.Pop();
                        break;
                    //print
                    case 3:
                        if (maxStack.Peek() == Int16.MinValue)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(maxStack.Peek());
                        }
                        break;
                }
            }
        }
    }
}

