using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class RansomeNote
    {
        public void checkMagazine()
        {
            //string[] mn = Console.ReadLine().Split(' ');
            //int m = Convert.ToInt32(mn[0]);

            //int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            //for(int i = 0;i <note.Length;i++)
            //{
            //    var indx = Array.IndexOf(magazine, note[i]);
            //    if(indx != -1)
            //    {
            //        magazine[indx] = "";
            //        if(i == note.Length - 1)
            //        {
            //            Console.WriteLine("Yes");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("No");
            //        break;
            //    }
            //}

            Dictionary<string, int> dictmgz = new Dictionary<string, int>();

            foreach (var str in magazine)
            {
                if (dictmgz.ContainsKey(str))
                {
                    dictmgz[str] += 1;
                }
                else
                {
                    dictmgz.Add(str, 1);
                }
            }
            var found = "Yes";
            foreach (var str in note)
            {
                if (dictmgz.ContainsKey(str))
                {
                    if (dictmgz[str] >= 1)
                    {
                        dictmgz[str] -= 1;
                    }
                    if (dictmgz[str] == 0)
                    {
                        dictmgz.Remove(str);
                    }
                }
                else
                {
                    found ="No";
                    break;
                }
            }
            Console.WriteLine(found);



        }
    }
}
