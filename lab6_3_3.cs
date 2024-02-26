using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab6_lev3_3
{
    struct Team
    {
        public string name;
        public int[] places;
        public int points;
        public Team (string name, int[] places, int points)
        {
            this.name = name;
            this.places = places;
            this.points = points;
        }
    }
    internal class Program
    {
        static void Calculate(ref Team team)
        {
            for(int i = 0; i < team.places.Length; i++)
            {
                if (team.places[i] == 1)
                {
                    team.points += 5;
                }
                else if (team.places[i] == 2)
                {
                    team.points += 4;
                }
                else if (team.places[i] == 3)
                {
                    team.points += 3;
                }
                else if (team.places[i] == 4)
                {
                    team.points += 2;
                }
                else if (team.places[i] == 5)
                {
                    team.points += 1;
                }
                else
                {
                    team.points += 0;
                }
            }
        }
        
        static Team Winner(Team team1, Team team2, Team team3)
        {
            if (team1.points > team2.points && team1.points > team3.points)
            {
                return team1;
            }
            else if (team2.points > team1.points && team2.points > team3.points)
            {
                return team2;
            }
            else if (team3.points > team1.points && team3.points > team2.points)
            {
                return team3;
            }
            else
            {
                if (team1.places[0] == 1)
                {
                    return team1;
                }
                else if (team2.places[0] == 1)
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

            Calculate(ref team1);
            Calculate(ref team2);
            Calculate(ref team3);
            
            Team win = Winner(team1, team2, team3);
            Console.WriteLine("Победила команда {0} набрав {1} очков", win.name, win.points);
            Console.ReadKey();

        }
    }
}
