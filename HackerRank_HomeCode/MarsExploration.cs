using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class MarsExploration
    {
        public void GettheCountofSignalChanged()
        {
            string s = Console.ReadLine();
            var alteredCharCount = 0;
            var sosSignal = "SOS";
            var index = 0;

            foreach(char c in s.ToCharArray())
            {
                if (c != sosSignal[index++])
                    alteredCharCount++;
                if(index %3 ==0)
                {
                    index = 0;
                }
            }
            Console.WriteLine(alteredCharCount);
        }
        
    }
}
