using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class GridSearch
    {
        public void IsPatternPresent()
        {
            string[] RC = Console.ReadLine().Split(' ');

            int R = Convert.ToInt32(RC[0]);

            int C = Convert.ToInt32(RC[1]);

            string[] G = new string[R];

            for (int i = 0; i < R; i++)
            {
                string GItem = Console.ReadLine();
                G[i] = GItem;
            }

            string[] rc = Console.ReadLine().Split(' ');

            int r = Convert.ToInt32(rc[0]);

            int c = Convert.ToInt32(rc[1]);

            string[] P = new string[r];

            for (int i = 0; i < r; i++)
            {
                string PItem = Console.ReadLine();
                P[i] = PItem;
            }

            var pattenfirststring = P[0];
            string PatternFound = "NO";
            int patternLength = pattenfirststring.Length;
            for (int i = 0;i <R;i++)
            {
                List<int> allmtchingcolindx = new List<int>();
                var rowindx = i;
                int patternfoundrowscount = 0;
                for (int j = 0; j < C; j++)
                {
                    //find all occurences
                    if (j + patternLength <= C)
                    {
                        var res = G[i].IndexOf(pattenfirststring, j, patternLength);
                        if (res != -1)
                            allmtchingcolindx.Add(res);
                    }
                    else
                    {
                        break;
                    }
                       
                }
                if(allmtchingcolindx.Any())
                {
                    rowindx =i + 1;

                    if (rowindx >= G.Length)
                    {
                        break;
                    }
                    foreach (var cidx in allmtchingcolindx)
                    {
                        rowindx = i + 1;

                        for (int j = 1; j < P.Length; j++)
                        {

                            if (rowindx >= G.Length)
                            {
                                break;
                            }
                            var pattrnindx = G[rowindx].IndexOf(P[j], cidx, patternLength);
                            if ((pattrnindx == -1) || (pattrnindx != cidx))
                            {
                                break;
                            }
                            else
                            {
                                patternfoundrowscount++;
                                rowindx++;
                            }

                        }
                        if (patternfoundrowscount == P.Length - 1)
                        {
                            PatternFound = "YES";
                        }
                    }
                }
               
                //var colindx = G[i].IndexOf(pattenfirststring,i,patternLength);
               
               
                ////if pattern found check subsequent patterns are present in the subsequent rows
                //if (G[i].Contains(pattenfirststring))
                //{
                   
                //    patternfoundrowscount++;
                //    for (int j = 1;j <P.Length;j++)
                //    {
                //        rowindx++;
                //        var pattrnindx = G[rowindx].IndexOf(P[j],colindx,patternLength);
                //        if((pattrnindx == -1) ||(pattrnindx != colindx))
                //        {
                //            break;
                //        }
                //        else
                //        {
                //            patternfoundrowscount++;
                //        }
                       
                //    }
                //    if(patternfoundrowscount == P.Length)
                //    {
                //        PatternFound = "YES";
                //    }
                //}
            }
            Console.WriteLine(PatternFound);

        }
    }
}
