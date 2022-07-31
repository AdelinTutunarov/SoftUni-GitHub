using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new List<Team>();
            CreateTeams(n, teams);
            AddMembers(teams);
            Output(teams);
        }

        private static void Output(List<Team> teams)
        {
            var teamsToDisband = teams.Where(team => team.members.Count == 0);
            var complatedTeams = teams.Where(team => team.members.Count > 0);
            complatedTeams = complatedTeams.OrderByDescending(team => team.members.Count()).ToList();
            teamsToDisband = teamsToDisband.OrderBy(team => team.teamName).ToList();
            foreach (var team in complatedTeams)
            {
                team.print();
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.teamName);
            }
        }

        private static void AddMembers(List<Team> teams)
        {
            string[] members = Console.ReadLine().Split("->");
            while (members[0] != "end of assignment")
            {
                bool teamExists = false;
                bool memberCanJoin = true;
                if (teams.Any(currTeam => currTeam.teamName == members[1])) teamExists = true;
                if (teams.Any(currTeam => currTeam.creator == members[0])) memberCanJoin = false;
                if (teamExists && memberCanJoin)
                {
                    foreach (var team in teams)
                    {
                        if (members[1] == team.teamName && team != null) team.members.Add(members[0]);
                    }
                }
                if (!teamExists) Console.WriteLine($"Team {members[1]} does not exist!");
                else if (!memberCanJoin) Console.WriteLine($"Member {members[0]} cannot join team {members[1]}!");
                members = Console.ReadLine().Split("->");
            }
        }

        private static void CreateTeams(int n, List<Team> teams)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                if (teams.Any(team => team.teamName == input[1])) Console.WriteLine($"Team {input[1]} was already created!");
                else if (teams.Any(team => team.creator == input[0])) Console.WriteLine($"{input[0]} cannot create another team!");
                else
                {
                    var team = new Team(input[1], input[0]);
                    team.members = new List<string>();
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                    teams.Add(team);
                }
            }
        }
    }

    class Team
    {
        public Team(string name, string user)
        {
            teamName = name;
            creator = user;
        }

        public string teamName { get; set; }
        public string creator { get; set; }
        public List<string> members { get; set; }
        public void print()
        {
            members.Sort();
            Console.WriteLine(teamName);
            Console.WriteLine($"- {creator}");
            foreach (var member in members)
            {
                Console.WriteLine($"-- {member}");
            }
        }
    }
}
