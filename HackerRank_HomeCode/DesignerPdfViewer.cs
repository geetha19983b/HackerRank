using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class DesignerPdfViewer
    {
        public void FindLetterHeight()
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine().ToLower();

            var chardict = new Dictionary<char, int>();
            var alphabet = 'a';
            foreach(var height in h)
            {
                chardict.Add(alphabet++, height);
            }
            int maxletterlength = 0;
            foreach(var letter in word)
            {
                if(chardict[letter] > maxletterlength)
                {
                    maxletterlength = chardict[letter];
                }
            }
            var areaofSelected = maxletterlength * word.Length;
            Console.WriteLine(areaofSelected);
        }
    }
}
