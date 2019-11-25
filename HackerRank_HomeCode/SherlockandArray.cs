using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class SherlockandArray
    {
        public void balancedSums()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            string result = "NO";
            int SumofArray = arr.Sum();
            int x = 0;
            int sum = 0;

            foreach(var y in arr)
            {
                if(2*x == SumofArray - y)
                {
                    result = "YES";
                }
                x = x + y;
            }
            Console.WriteLine(result);
        }
    }
}
