using System;

struct Team
{
    private string name;
    private int goals_scored;
    private int goals_conceded;
    private int points;

    public string Name => name;
    public int GoalsScored => goals_scored;
    public int GoalsConceded => goals_conceded;
    public int Points => points;

    public Team(string name, int goalsScored, int goalsConceded) 
    {
        this.name = name;
        this.goals_scored = goalsScored;
        this.goals_conceded = goalsConceded;
        if (goalsScored > goalsConceded)
        {
            this.points = 3;
        }
        else if (goalsScored == goalsConceded)
        {
            this.points = 1;
        }
        else
        {
            this.points = 0;
        }
    }

    public string PrintTeamInfo()
    {
        return $"{Name}: {Points} очков";
    }
}

class Program
{
    static void Main()
    {
        Team[] teams = new Team[5];
        teams[0] = new Team("бби-23-1", 3, 1);
        teams[1] = new Team("бби-23-2", 1, 1);
        teams[2] = new Team("бби-23-3", 4, 0);
        teams[3] = new Team("бби-23-4", 2, 3);
        teams[4] = new Team("бби-23-5", 2, 2);

        Array.Sort(teams, (x, y) => 
        {
            if (x.Points != y.Points)
                return y.Points.CompareTo(x.Points); 
            else
                return (y.GoalsScored - y.GoalsConceded).CompareTo(x.GoalsScored - x.GoalsConceded); 
        });

        Console.WriteLine("Таблица результатов:");

        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].PrintTeamInfo()}");
        }
    }
}

