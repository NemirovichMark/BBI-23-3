using System;

public struct Team
{
    private int[] results;

    public Team(int[] results)
    {
        this.results = results;
    }

    public int SumPoints()
    {
        int points = 0;
        for (int i = 0; i < results.Length; i++)
        {
            int t = 6 - results[i];
           if (t<=5)
            {
                points += t;
            }
           else
            {
                points += 0;
            }
        }
        return points;
    }
}

class Program
{
    static void Main()
    {
        int[] resultsTeam1 = { 1, 2, 3, 4, 5, 6 };
        int[] resultsTeam2 = { 7, 8, 9, 10, 11, 12 };
        int[] resultsTeam3 = { 13, 14, 15, 16, 17, 18 };

        Team team1 = new Team(resultsTeam1);
        Team team2 = new Team(resultsTeam2);
        Team team3 = new Team(resultsTeam3);

        int pointsTeam1 = team1.SumPoints();
        int pointsTeam2 = team2.SumPoints();
        int pointsTeam3 = team3.SumPoints();

        if (pointsTeam1 > pointsTeam2 && pointsTeam1 > pointsTeam3)
        {
            Console.WriteLine("Команда 1 победила с " + pointsTeam1 + " баллами");
        }
        else if (pointsTeam2 > pointsTeam1 && pointsTeam2 > pointsTeam3)
        {
            Console.WriteLine("Команда 2 победила с " + pointsTeam2 + " баллами");
        }
        else if (pointsTeam3 > pointsTeam1 && pointsTeam3 > pointsTeam2)
        {
            Console.WriteLine("Команда 3 победила с " + pointsTeam2 + " баллами");
        }
        else if (pointsTeam1 == pointsTeam2 || pointsTeam1 == pointsTeam3 || pointsTeam2 == pointsTeam3)
        {
            int firstPlaceTeam1 = resultsTeam1[0];
            int firstPlaceTeam2 = resultsTeam2[0];
            int firstPlaceTeam3 = resultsTeam3[0];

            if (firstPlaceTeam1 == 1)
            {
                Console.WriteLine("Команда 1 победила с " + pointsTeam1 + " баллами");
            }
            else if (firstPlaceTeam2 == 1)
            {
                Console.WriteLine("Команда 2 победила с " + pointsTeam2 + " баллами");
            }
            else if (firstPlaceTeam3 == 1)
            {
                Console.WriteLine("Команда 3 победила с " + pointsTeam3 + " баллами");
            }
        }
    }
}

