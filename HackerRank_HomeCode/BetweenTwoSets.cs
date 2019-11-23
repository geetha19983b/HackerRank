using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BetweenTwoSets
    {
        public void FindTotal()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
            var totalXs = 0;
            var maximumA = arr.Max(); 
            var minimumB = brr.Min(); 
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while(multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;
                foreach (var item in arr)
                {
                    if(multipleOfMaxA % item != 0 )
                    {
                        factorOfAll = false;
                        break;
                    }
                }
                if(factorOfAll)
                {
                    foreach(var item in brr)
                    {
                        if(item % multipleOfMaxA != 0 )
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }
                if(factorOfAll)
                {
                    totalXs++;
                }
                counter++;
                multipleOfMaxA = maximumA * counter;

            }


            Console.WriteLine(totalXs);
        }
     }
}
