using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITeammate> FrontEnd = new List<ITeammate>()
            {
                new Leah(),
                new Natasha(),
                new Seth()
            };

            List<ITeammate> BackEnd = new List<ITeammate>();

            Robert Robert = new Robert();
            Aaron Aaron = new Aaron();
            Will Will = new Will();


            BackEnd.Add(Robert);
            BackEnd.Add(Will);
            BackEnd.Add(Aaron);

            foreach (ITeammate member in FrontEnd)
            {
                member.Work();
            }

            foreach (ITeammate member in BackEnd)
            {
                member.Work();
            }
        }
    }
}
