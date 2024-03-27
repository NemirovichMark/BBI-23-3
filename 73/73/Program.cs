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
            if (t <= 5 && t>0)
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
        int[] resultsTeam1 = { 1, 2, 3, 4, 5, 6 };
        int[] resultsTeam2 = { 7, 8, 9, 10, 11, 12 };
        int[] resultsTeam3 = { 13, 14, 15, 16, 17, 18 };

        Team team1 = new WomenTeam(resultsTeam1);
        Team team2 = new MenTeam(resultsTeam2);
        Team team3 = new WomenTeam(resultsTeam3);

        int pointsTeam1 = team1.SumPoints();
        int pointsTeam2 = team2.SumPoints();
        int pointsTeam3 = team3.SumPoints();

        Team winner = pointsTeam1 > pointsTeam2 ? (pointsTeam1 > pointsTeam3 ? team1 : team3) : (pointsTeam2 > pointsTeam3 ? team2 : team3);

        Console.WriteLine("Победила " + (winner is MenTeam ? "мужская команда" : "женская команда") + " с " + winner.SumPoints() + " баллами");
    }
}

