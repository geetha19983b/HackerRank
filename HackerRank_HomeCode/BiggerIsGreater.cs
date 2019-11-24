using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BiggerIsGreater
    {
        public void GetBiggerString()
        {
            string result = "no answer";
            string word = Console.ReadLine();
            if (word.Length == 1)
            {
                Console.WriteLine(result);
                return;
            }

            int maxLexoC1 = 0;
            int maxLexoC2 = 0;

            //Find the largest index char that is weakly increasing such as g in hefg 
            for (int j = 1; j < word.Length; j++)
            {
                bool condition1 = word[j] > word[j - 1];

                if (condition1)
                {
                    maxLexoC1 = (j > maxLexoC1) ? j : maxLexoC1;
                }
            }


            //if our only increasing is at point 0 then we are in the last permuation of our string
            if (maxLexoC1 == 0) {
                Console.WriteLine(result);
                return;
            }

            //maxLexoC2
            //Determine the right most char greater than the pivot in index and in lexo
            for (int j = maxLexoC1; j < word.Length; j++)
            {
                bool condition2 = word[j] > word[maxLexoC1 - 1];

                if (condition2)
                {
                    maxLexoC2 = j;
                }
            }
            StringBuilder wordSB = new StringBuilder(word);

            //Swap the pivot with maxLexoC2
            char tmp = wordSB[maxLexoC1 - 1];
            wordSB[maxLexoC1 - 1]= wordSB[maxLexoC2];
            wordSB[maxLexoC2]= tmp;

            //Reverse starting at the element to the right of the pivot
            int left = maxLexoC1;
            int right = wordSB.Length - 1;
            while (left < right)
            {
                //swap left with right
                tmp = wordSB[left];
                wordSB[left]= wordSB[right];
                wordSB[right]=tmp;
                left++;
                right--;
            }
            result = wordSB.ToString();
            Console.WriteLine(result);
        }
    }
}
