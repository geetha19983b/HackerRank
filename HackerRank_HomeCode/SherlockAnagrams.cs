using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class SherlockAnagrams
    {
        public void getAnagramPairs()
        {
          //  var T = int.Parse(Console.ReadLine());
            var sd = new Dictionary<char, int>();
            var total = new Dictionary<int, int>();
            var sb = new StringBuilder();
            //while (T-- > 0)
            //{
                total.Clear();
                // convert to 0, 1
                var S = Console.ReadLine();
                // substring length
                for (var i = 1; i < S.Length; i++)
                {
                    for (var j = 0; j <= S.Length - i; j++)
                    {
                        sd.Clear();
                        for (var k = j; k < j + i; k++)
                        {
                            // get hashcode of substring
                            if (sd.ContainsKey(S[k]))
                            {
                                sd[S[k]]++;
                            }
                            else
                            {
                                sd.Add(S[k], 1);
                            }
                        }
                        // convert to hash code
                        sb.Clear();
                        foreach (var item in sd.OrderBy(s => s.Key))
                        {
                            sb.Append(item.Key + item.Value.ToString());
                        }
                        var key = sb.ToString().GetHashCode();
                        if (total.ContainsKey(key))
                        {
                            total[key]++;
                        }
                        else
                        {
                            total.Add(key, 1);
                        }
                    }
                }
                // get pairs
                long result = 0;
                foreach (var item in total)
                {
                    result += item.Value * (item.Value - 1) / 2;
                }
                Console.WriteLine(result);
           // }
        }
    }
}
