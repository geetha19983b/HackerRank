using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank_HomeCode
{
    public class ClimbingLeaderboard
    {
        public void GetOptimizedAliceRanK()
        {

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));


            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));
            int n = scores.Length;
            int m = alice.Length;
            int[] rank = new int[n];
            int[] res = new int[m];
            for (int i = 1; i < n; i++)
            {
                if (scores[i] == scores[i - 1])
                {
                    rank[i] = rank[i - 1];
                }
                else
                {
                    rank[i] = rank[i - 1] + 1;
                }
            }

            for (int i = 0; i < m; i++)
            {
                int alicescore = alice[i];
                if (alicescore > scores[0])
                {
                    res[i] = 1;
                }
                else if(alicescore< scores[n-1])
                {
                    res[i] = rank[n - 1] + 1;
                }
                else
                {
                    int index = binarySearch(scores, alicescore);
                    res[i] = rank[index];
                }
            }
            Array.ForEach(res, x => Console.WriteLine(x));

        }
        public  static int binarySearch(int[] a,int key)
        {
            int lo = 0;
            int hi = a.Length - 1;

            while(lo <=hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (a[mid] == key)
                    return mid;
                else if(a[mid] < key && key < a[mid -1])
                {
                    return mid;
                }
                else if (a[mid] > key && key >= a[mid + 1])
                {
                    return mid + 1;
                }
                else if (a[mid] < key)
                {
                    hi = mid - 1;
                }
                else if(a[mid]> key)
                {
                    lo = mid + 1;
                }

            }
            return -1;
        }
        public void GetAliceRank()
        {
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));


            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            int[] NondupsScores = scores.Distinct().ToArray();
            int[] alicerank = new int[alice.Length];
            List<int> ar = new List<int>();

            foreach (var score in alice)
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

                if (score >= closest)
                {
                    currRank = ind + 1;
                }
                else
                {
                    currRank = ind + 2;
                }

                if (currRank == 0)
                {
                    if (score < NondupsScores[NondupsScores.Length - 1])
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
