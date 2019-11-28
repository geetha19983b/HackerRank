using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_HomeCode
{
    public class CeaserCipher
    {
        public void EncryptedString()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();
            
            int k = Convert.ToInt32(Console.ReadLine());
            StringBuilder encryptedstring = new StringBuilder();
            int shiftFactor = k;

            if(shiftFactor > 26)
            {
                shiftFactor = shiftFactor % 26;
            }
            for(int i = 0;i<s.Length;i++)
            {
                var asciiCode = (int)s[i];

                //small characters
                if (asciiCode > 96 && asciiCode <= 122)
                {
                    if (asciiCode + shiftFactor <= 122)
                    {
                        encryptedstring.Append((char)(((int)s[i]) + shiftFactor));
                    }
                    else
                    {
                        var offset = shiftFactor - (122 - asciiCode);
                        encryptedstring.Append(((char)(96 + offset)));
                    }
                }
                else if (asciiCode <= 90 && asciiCode > 64)
                {
                    //upper case alphabets
                    if (asciiCode + shiftFactor <= 90)
                        //we're within range. Replace the encoded character
                        encryptedstring.Append(((char)(((int)s[i]) + shiftFactor)));
                    else
                    {
                        var offset = shiftFactor - (90 - asciiCode);
                        encryptedstring.Append(((char)(64 + offset)));
                    }
                }
                else
                {
                    encryptedstring.Append(s[i]);
                }
            }
            Console.WriteLine(encryptedstring.ToString());
        }
    }
}
