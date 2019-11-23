using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class CatMouse
    {
        public void WhoWillWin()
        {
            string[] xyz = Console.ReadLine().Split(' ');

            //cats a pos

            int x = Convert.ToInt32(xyz[0]);

            //cat b pos

            int y = Convert.ToInt32(xyz[1]);
            //mouse pos
            int z = Convert.ToInt32(xyz[2]);

            var catA_toMouse = Math.Abs(x - z);
            var catB_toMouse = Math.Abs(y - z);
            if(catA_toMouse < catB_toMouse)
            {
                Console.WriteLine("Cat A");
            }
            else if(catB_toMouse < catA_toMouse)
            {
                Console.WriteLine("Cat B");
            }
            else
            {
                Console.WriteLine("Mouse C");
            }

        }
    }
}
