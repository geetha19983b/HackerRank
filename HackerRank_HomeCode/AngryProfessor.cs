using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class AngryProfessor
    {
        public void ClassStatus()
        {
            string[] nk = Console.ReadLine().Split(' ');
            //no of students
            int n = Convert.ToInt32(nk[0]);
            //min students to be present for class
            int k = Convert.ToInt32(nk[1]);
            //students arrival time
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            var studs_Ontime = (from t in a
                                where t == 0 || t < 0
                                select t).Count();
            string Isclasscancelled;
            if(studs_Ontime < k)
            {
                Isclasscancelled = "YES";
            }
            else
            {
                Isclasscancelled = "NO";
            }
            Console.WriteLine(Isclasscancelled);
        }
    }
}
