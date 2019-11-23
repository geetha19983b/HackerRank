using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace HackerRank_HomeCode
{
    public class ACMIPC
    {
        public void FindteamCombwithMaxSkills()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            string[] topic = new string[n];

            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic[i] = topicItem;
            }
            int maxSkills = 0;
            int maxSkillTeams = 0;
            Dictionary<string, int> teamskills = new Dictionary<string, int>();
            for (int i = 0;i < n;i++)
            {
                String member1 = topic[i];
                for (int j = i+1;j<n;j++)
                {
                    
                    String member2 = topic[j];
                    int skillSet = 0;

                    for (int k = 0; k < m; k++)
                    {
                        if (member1[k] == '1' || member2[k] == '1')
                        {
                            skillSet++;
                        }
                    }
                    var team = i+1 + "," + j + 1;
                    teamskills.Add(team, skillSet);
                    //maxSkillTeams += (maxSkills == skillSet) ? 1 : 0;
                    //if (skillSet > maxSkills)
                    //{
                    //    maxSkillTeams = 1;
                    //    maxSkills = skillSet;
                    //}

                }
            }
            maxSkills = teamskills.Values.Max();
            maxSkillTeams = teamskills.Count(x => x.Value == maxSkills);
            int[] maxdetials = new int[2];
            maxdetials[0] = maxSkills;
            maxdetials[1] = maxSkillTeams;
            Array.ForEach(maxdetials, x => Console.WriteLine(x));
        }
    }
}
