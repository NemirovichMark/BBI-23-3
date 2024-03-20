using System;

public class Team
{
    protected int[] results;

    public Team(int[] results)
    {
        this.results = results;
    }

    public virtual int SumPoints()
    {
        int points = 0;
        for (int i = 0; i < results.Length; i++)
        {
            int t = 6 - results[i];
            if (t <= 5 && t > 0)
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

public class WomenTeam : Team
{
    public WomenTeam(int[] results) : base(results)
    {
    }
}

public class MenTeam : Team
{
    public MenTeam(int[] results) : base(results)
    {
    }
}

class Program
{
    static void Main()
    {
        int[] resultsTeam1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] resultsTeam2 = { 10, 11, 12, 13, 14, 15, 16, 17, 18 };

        Team team1 = new WomenTeam(resultsTeam1);
        Team team2 = new MenTeam(resultsTeam2);

        int pointsTeam1 = team1.SumPoints();
        int pointsTeam2 = team2.SumPoints();

        Team winner = pointsTeam1 > pointsTeam2 ? team1 : team2;

        Console.WriteLine("Победила " + (winner is MenTeam ? "мужская команда" : "женская команда") + " с " + winner.SumPoints() + " баллами");
    }
}
