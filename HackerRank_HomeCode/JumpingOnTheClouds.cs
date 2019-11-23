using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class JumpingOnTheClouds
    {
        public void FindNoOfJumps()
        {
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int emmapos = 0;
            int jumpcount = 0;

            while(true)
            {
                if(emmapos + 2 <= c.Length -1 && c[emmapos + 2] == 0)
                {
                    emmapos = emmapos + 2;
                }
                else
                {
                    emmapos++;
                }
                jumpcount++;
                if (emmapos == c.Length - 1)
                    break;
            }
            Console.WriteLine(jumpcount);
               
        }
    }
}
