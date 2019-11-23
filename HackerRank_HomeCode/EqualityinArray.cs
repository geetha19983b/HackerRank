using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class EqualityinArray
    {
        public void EqualizeArray()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach(var item in arr)
            {
                if(map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            //find the max in the mp
            var maxFreq = map.Values.Max();
            Console.WriteLine(arr.Length - maxFreq);
        
        }
    }
}
