using System;
using System.Linq;
using System.Collections.Generic;
using FootballTeamGenerator.Exceptions;

namespace FootballTeamGenerator
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArguments = command
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string teamName = commandArguments[1];

                try
                {
                    if (command.StartsWith("Team"))
                    {
                        this.AddTeam(teamName);
                    }
                    else if (command.StartsWith("Add"))
                    {
                        this.AddPlayerToTeam(commandArguments, teamName);
                    }
                    else if (command.StartsWith("Remove"))
                    {
                        this.RemovePLayerFromTeam(commandArguments, teamName);
                    }
                    else if (command.StartsWith("Rating"))
                    {
                        Team targetTeam = this.ValidateTeamExist(this.teams, teamName);

                        Console.WriteLine(targetTeam);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                command = Console.ReadLine();
            }
        }

        private void AddTeam(string teamName)
        {
            Team team = new Team(teamName);
            this.teams.Add(team);
        }

        private void AddPlayerToTeam(string[] commandArguments, string teamName)
        {
            Team currentTeam = this.ValidateTeamExist(teams, teamName);

            string playerName = commandArguments[2];

            Stats stats = this.CreateStats(commandArguments.Skip(3).ToArray());

            Player player = new Player(playerName, stats);

            currentTeam.AddPlayer(player);
        }

        private void RemovePLayerFromTeam(string[] commandArguments, string teamName)
        {
            string playerName = commandArguments[2];

            Team currentPlayer = this.teams.FirstOrDefault(x => x.Name == teamName);

            currentPlayer.RemovePlayer(playerName);
        }

        private Stats CreateStats(string[] commandArguments)
        {
            int endurance = int.Parse(commandArguments[0]);
            int sprint = int.Parse(commandArguments[1]);
            int dribble = int.Parse(commandArguments[2]);
            int passing = int.Parse(commandArguments[3]);
            int shooting = int.Parse(commandArguments[4]);

            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

            return stats;
        }

        private Team ValidateTeamExist(List<Team> teams, string teamName)
        {
            var currentTeam = teams.FirstOrDefault(x => x.Name == teamName);

            if (currentTeam == null)
            {
                throw new ArgumentException(string.Format(GlobalExceptions.NonExistentTeamExceptionMessage, teamName));
            }

            return currentTeam;
        }
    }
}
