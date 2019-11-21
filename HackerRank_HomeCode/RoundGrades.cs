using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class RoundGrades
    {
        public void RoundedGrades()
        {
            Console.WriteLine("Enter number of grades ");
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();
            Console.WriteLine("Enter the grades ");
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    var mod5 = grades[i] % 5;
                    var nextmulof5 = (grades[i] - mod5) + 5;
                    if ((nextmulof5 - grades[i]) < 3)
                    {
                        grades[i] = nextmulof5;

                    }
                }
            }
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
