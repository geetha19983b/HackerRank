using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class LisaWorkBook
    {
        public void FindSpecialProbs()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;

            long currPage = 0;
            int specialprobs = 0;

            for(int i = 0;i <arr.Length;i++)
            {
                var questioncount = arr[i];
                int qstrIndx = 0;
                int qendIndx = 0;
                while(questioncount > 0)
                {
                    currPage++;

                    qstrIndx = qendIndx + 1;
                    if(questioncount > k)
                    {
                        qendIndx = qendIndx + k;
                    }
                    else
                    {
                        qendIndx = qendIndx + questioncount;
                    }

                    questioncount = questioncount - k;
                    if(currPage >= qstrIndx && currPage <= qendIndx)
                    {
                        specialprobs++;

                    }

                }
            }
            Console.WriteLine(specialprobs);
        }
    }
}
