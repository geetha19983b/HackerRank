using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class ManasaAndStones
    {
        public void FindtheLastStone()
        {
            List<int> lstStone = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            if(a == b)
            {
                lstStone.Add((n - 1) * a);
            }
            else
            {
                if(b <a)
                {
                    var temp = b;
                    b = a;
                    a = temp;
                }

                for(int i = 0;i <n;i++)
                {
                    var res = (a * (n - 1 - i) + b * i);
                    lstStone.Add(res);
                  
                }
            }
            lstStone.ForEach(x => Console.WriteLine(x));
        }
    }
}
