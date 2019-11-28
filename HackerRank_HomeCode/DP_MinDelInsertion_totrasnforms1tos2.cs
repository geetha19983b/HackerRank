using System;
using System.Collections.Generic;
using System.Text;
//https://www.youtube.com/watch?v=_X0tcTEDOfA
namespace HackerRank_HomeCode
{
    public class DP_MinDelInsertion_totrasnforms1tos2
    {
        public void findMinDelInsertion()
        {
            string s1 = "bright";
            string s2 = "night";
            //del is 2 insert is 1 to transform s1 to s2
            //find the lcs
            char[] x = s1.ToCharArray();
            char[] y = s2.ToCharArray();
            int m = s1.Length;
            int n = s2.Length;

            DP_LongestCommonSubsequence lc = new DP_LongestCommonSubsequence();
            var lcslen = lc.LCSM2(x, y, m,n);
            Console.WriteLine($"Min del required : {s1.Length -lcslen}");
            Console.WriteLine($"Min insertion req : {(s2.Length - lcslen)}");



        }
    }
}

//min no of insertion deletion algo
//1)calculate the lcs of the two srtings
//2)to transform s1 to s2 we need to
//delete from s1 which is not part of lcs
//so del required in s1 = s1length - lcslength
//3)we need to insert everything in s1 which is
//present in s2 but not part of lcs
//insertion req in s1 = s2length - lcslength

//transforts1tos2(s1, s2)
//{
//    lcslen = findlcslen(s1, s2);
//    del = s1.length - lcsleng
//ins = s2.length - lcslen
//}