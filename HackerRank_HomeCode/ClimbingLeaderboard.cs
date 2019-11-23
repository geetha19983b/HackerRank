using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class ClimbingLeaderboard
    {
        public void GetAliceRank()
        {
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));


            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            int[] NondupsScores = scores.Distinct().ToArray();
            int[] alicerank =new int[alice.Length];
            List<int> ar = new List<int>();

            foreach(var score in alice)
            {
                int currRank = 0;


                //for(int i = 0;i<NondupsScores.Length;i++)
                //{
                //    if(score >= NondupsScores[i])
                //    {
                //        currRank = i + 1;
                //        break;
                //    }
                //}
                var closest = NondupsScores.OrderBy(x => Math.Abs(x - score)).First();
                var ind = Array.FindIndex(NondupsScores, x => x == closest);
                //Console.WriteLine("For score " + score + " closest is " + closest + " and its index is " + ind);

                if(score >= closest)
                {
                    currRank = ind + 1;
                }
                else
                {
                    currRank = ind + 2;
                }
                
                if(currRank == 0 )
                {
                    if(score < NondupsScores[NondupsScores.Length -1])
                    {
                        currRank = NondupsScores.Length + 1;
                    }
                }
               // Console.WriteLine("rank for score " + currRank + "score " + score);
                ar.Add(currRank);
                
            }
            alicerank = ar.ToArray();
            alicerank.ToList().ForEach(x => Console.Write(x));

        }
    }
}
