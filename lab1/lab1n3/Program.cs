using System;

namespace lab3n3
{
    struct Team
    {
        public int[] results;

        public Team(int[] _results)
        {
            results = _results;
        }

        public int CalculatePoints()
        {
            int totalPoints = 0;
            for(int i = 0; i < results.Length; i++)
            {
                if(results[i] < 6)
                {
                    totalPoints += 5 + 1 - results[i];
                }
            }
            return totalPoints;
        }

        public int FirstPlace()
        {
            int k = 0;
            for(int i = 0; i < results.Length; i++)
            {
                if(results[i] == 1)
                {
                    k = 1;
                }
            }
            return k;
        }
    }

    class Program
    {
        static void Main() 
        {
            int[] team1Results = { 13, 8, 7, 2, 5, 6 }; 
            int[] team2Results = { 3, 4, 9, 10, 11, 12 }; 
            int[] team3Results = { 1, 14, 15, 16, 17, 18 }; 

            Team team1 = new Team(team1Results);
            Team team2 = new Team(team2Results);
            Team team3 = new Team(team3Results);

            int pointsTeam1 = team1.CalculatePoints();
            int pointsTeam2 = team2.CalculatePoints();
            int pointsTeam3 = team3.CalculatePoints();

            int k1 = team1.FirstPlace();
            int k2 = team2.FirstPlace();
            int k3 = team3.FirstPlace();

            if (pointsTeam1 > pointsTeam2 && pointsTeam1 > pointsTeam3)
            {
                Console.WriteLine("Победитель - Команда 1, Набрано баллов: {0}", pointsTeam1);
            }
            else if (pointsTeam2 > pointsTeam1 && pointsTeam2 > pointsTeam3)
            {
                Console.WriteLine("Победитель - Команда 2, Набрано баллов: {0}", pointsTeam2);
            }
            else if (pointsTeam3 > pointsTeam1 && pointsTeam3 > pointsTeam2)
            {
                Console.WriteLine("Победитель - Команда 3, Набрано баллов: {0}", pointsTeam3);
            }
            else if (k1 == 1)
            {
                Console.WriteLine("Победитель - Команда 1, Набрано баллов: {0}", pointsTeam1);
            }
            else if (k2 == 1)
            {
                Console.WriteLine("Победитель - Команда 2, Набрано баллов: {0}", pointsTeam2);
            }
            else if (k3 == 1)
            {
                Console.WriteLine("Победитель - Команда 3, Набрано баллов: {0}", pointsTeam3);
            }

        }
    }
}
