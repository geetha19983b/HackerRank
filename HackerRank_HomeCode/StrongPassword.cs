using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank_HomeCode
{
    public class StrongPassword
    {
        public void NoOfExtraChars()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string password = Console.ReadLine();

            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            var digitOccured = false;
            var lowerCaseOccured = false;
            var upperCaseOccured = false;
            var specialCharsOccured = false;

            int extraChars = 0;
            int desiredLength = 0;


            foreach (char nextChar in password)
            {
                desiredLength++;
                if (nextChar >= 48 && nextChar <= 57)
                    digitOccured = true;

                if (nextChar >= 97 && nextChar <= 122)
                    lowerCaseOccured = true;

                if (nextChar >= 65 && nextChar <= 90)
                    upperCaseOccured = true;


                if (nextChar == 33
                   || nextChar == 64
                   || nextChar == 94
                   || nextChar == 45
                   ) //!@^-
                    specialCharsOccured = true;

                if (nextChar >= 35 && nextChar <= 38) //#$%&
                    specialCharsOccured = true;


                if (nextChar >= 40 && nextChar <= 43) //()*+
                    specialCharsOccured = true;

                if (digitOccured && lowerCaseOccured && upperCaseOccured && specialCharsOccured && desiredLength >= 6)
                    break;


            }


            if (!digitOccured)
                extraChars++;

            if (!lowerCaseOccured)
                extraChars++;

            if (!upperCaseOccured)
                extraChars++;

            if (!specialCharsOccured)
                extraChars++;

            if (desiredLength + extraChars < 6)
                extraChars += 6 - extraChars - desiredLength;

            Console.WriteLine(extraChars);

        }
    }
}
