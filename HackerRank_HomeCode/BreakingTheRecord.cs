using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class BreakingTheRecord
    {
        public void TotalRecrdBreak()
        {
            var minRecordBroken = 0;
            var maxRecordBroken = 0;

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));  

            if(scores.Length >1)
            {
                var minRecord = scores[0];
                var maxRecord = scores[0];
                for(int i = 1;i< scores.Length;i++)
                {
                    if(scores[i]< minRecord)
                    {
                        minRecordBroken++;
                        minRecord = scores[i];
                    }
                    if(scores[i] > maxRecord)
                    {
                        maxRecordBroken++;
                        maxRecord = scores[i];
                    }
                }
            }
            int []rcrdbrkn = new int[] { maxRecordBroken, minRecordBroken };
            Console.WriteLine(rcrdbrkn);
        }
    }
}
