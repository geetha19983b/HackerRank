using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class HappyLadyBugs
    {
        public void IsLadyBugHappy()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string b = Console.ReadLine();

            string isHappy = "NO";

            Dictionary<char, int> colorFreq = new Dictionary<char, int>();
            foreach(char c in b.ToCharArray())
            {
                if(colorFreq.ContainsKey(c))
                {
                    colorFreq[c]++;
                }
                else
                {
                    colorFreq.Add(c, 1);
                }
            }

            int underscorecount = 0;
            colorFreq.TryGetValue('_', out underscorecount);

            //if there are no 2 color freq and there are no empty spaces
           
            foreach (var freq in colorFreq.Where(x => x.Key != '_').Select(x => x.Value).ToList())
            {
                if (freq < 2)
                {
                    isHappy = "NO";
                    Console.WriteLine(isHappy);
                    return;

                }
            }
            //if underscore count is 0 check if existing are in order
            if(underscorecount == 0)
            {
                int count = 0;
                char lastChar = b[0];
                for(int i = 0;i < b.Length;i++)
                {
                    char currChar = b[i];
                    if(currChar == lastChar)
                    {
                        count++;
                    }
                    else
                    {
                        if(count < 2)
                        {
                            isHappy = "NO";
                            Console.WriteLine(isHappy);
                            return;
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    lastChar = currChar;
                }
                isHappy = "Yes";
            }
            else
            {
                //underscore present and there are atlest 2 of each color then we can shuffle
                isHappy = "YES";
            }
            Console.WriteLine(isHappy);
        }
    }
}
