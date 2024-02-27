using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab6_lev3_3
{
    internal class Program
    {
        struct Team
        {
            private string name;
            private int[] places;
            private int points;
            public string Name => name;
            public int[] Places => places;
            public int Points
            {
                get { return points; }
                set { points = value; }
            }

            public Team (string name, int[] places, int points)
    {
        this.name = name;
        this.places = places;
        this.points = points;
    }
    }
   
          
        static int Calculate( Team team)
        {
            int totalPoints = 0;
            for (int i = 0; i < team.Places.Length; i++)
            {
                if (team.Places[i] == 1)
                {
                    totalPoints += 5;
                }
                else if (team.Places[i] == 2)
                {
                    totalPoints += 4;
                }
                else if (team.Places[i] == 3)
                {
                    totalPoints += 3;
                }
                else if (team.Places[i] == 4)
                {
                    totalPoints += 2;
                }
                else if (team.Places[i] == 5)
                {
                    totalPoints += 1;
                }
                else
                {
                    totalPoints += 0;
                }
            }
            return totalPoints;
        }
        
        static Team Winner(Team team1, Team team2, Team team3)
        {
            if (team1.Points > team2.Points && team1.Points > team3.Points)
            {
                return team1;
            }
            else if (team2.Points > team1.Points && team2.Points > team3.Points)
            {
                return team2;
            }
            else if (team3.Points > team1.Points && team3.Points > team2.Points)
            {
                return team3;
            }
            else
            {
                if (team1.Places[0] == 1)
                {
                    return team1;
                }
                else if (team2.Places[0] == 1)
                {
                    return team2;
                }
                else
                {
                    return team3;
                }
            }
        }
        static void Main(string[] args)
        {
            Team team1 = new Team("A", new int[] { 11, 8, 9, 13, 17, 4 }, 0);
            Team team2 = new Team("B", new int[] { 7, 6, 10, 14, 18, 12 }, 0);
            Team team3 = new Team("C", new int[] { 3, 2, 1, 15, 16, 5 }, 0);

            
            team1.Points = Calculate(team1);
            team2.Points = Calculate(team2);
            team3.Points = Calculate(team3);

            Team win = Winner(team1, team2, team3);
            Console.WriteLine("Победила команда {0} набрав {1} очков", win.Name, win.Points);
            Console.ReadKey();
         }
          }
}
