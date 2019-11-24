using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class ChocolateFeast
    {
        public void FindNoOfchocs()
        {
            string[] ncm = Console.ReadLine().Split(' ');

            //total amount 
            int n = Convert.ToInt32(ncm[0]);
            //cost of choc
            int c = Convert.ToInt32(ncm[1]);
            //how many wrappers can be excanged ofr a choc
            int m = Convert.ToInt32(ncm[2]);

            var totalChoc = n / c;
            var wrappersfromchos = totalChoc;

            while(wrappersfromchos >= m)
            {
                totalChoc += wrappersfromchos / m;
                wrappersfromchos = (wrappersfromchos / m) + (wrappersfromchos % m);
            }

            Console.WriteLine(totalChoc); ;

        }
    }
}
