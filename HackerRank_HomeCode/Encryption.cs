using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class Encryption
    {
        public void Encrypt()
        {
            string encryptedtext = "";
            string s = Console.ReadLine();
            string swithoutspace = new string(s.Where(c => !Char.IsWhiteSpace(c)).ToArray());
            var colCount = (int)Math.Ceiling(Math.Sqrt(swithoutspace.Length));

            for (int i = 0; i < colCount; i++)
            {
                var counter = 0;
                while (i + (counter * colCount) < swithoutspace.Length)
                {
                    encryptedtext += swithoutspace[i + (counter * colCount)];
                    counter++;
                }
                //Console.Write(' ');
                encryptedtext += " ";
            }
            Console.WriteLine(encryptedtext);
        }


    }

}
