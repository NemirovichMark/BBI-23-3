using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace новикова_лаба_6_уровень_3
{
    struct FootballTeam
    {
        private string name;
        private int goalsScored;
        private int goalsConceded;
        private int points;
        private int goaldifference;

        public FootballTeam(string name, int goalsScored, int goalsConceded, int points)
        {
            this.name = name;
            this.points = points;
            this.goalsConceded = goalsConceded;
            this.goalsScored = goalsScored;
            this.goaldifference = goalsScored - goalsConceded;
        }

        public string Name
        {
            get { return name; }
        }

        public int GoalsScored
        {
            get { return goalsScored; }
        }

        public int GoalsConceded
        {
            get { return goalsConceded; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public int GoalsDifference
        {
            get { return goaldifference; }
        }

      

        public void Print()
        {

            Console.WriteLine("Название команды {0}  \t {1}; {2}; {3}", name, goalsScored, goalsConceded, points);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            FootballTeam[] teams = new FootballTeam[]
            {
            new FootballTeam("команда 1", 5, 2, 0),
            new FootballTeam("команда 2", 3, 4, 0),
            new FootballTeam("команда 3", 4, 1, 0),
            new FootballTeam("команда 4", 2, 2, 0)
            };

            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i].GoalsScored > teams[i].GoalsConceded)
                    teams[i].Points = 3;
                else if (teams[i].GoalsScored == teams[i].GoalsConceded)
                    teams[i].Points = 1;
                else
                    teams[i].Points = 0;
            }


            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = i + 1; j < teams.Length; j++)
                {
                    if (teams[i].Points < teams[j].Points ||
                        (teams[i].Points == teams[j].Points && (teams[i].GoalsDifference) < (teams[j].GoalsDifference)))
                    {
                        FootballTeam temp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = temp;
                    }
                }

            }
            foreach (FootballTeam t in teams)
            {
                t.Print();

            }
        }
    }
}
