using System;

struct Team
{
    private string _name;
    private int _scoredgoals;
    private int _concededgoals;
    private int _total;

    public string Name => _name;
    public int scoredgoals => _scoredgoals;
    public int concededgoals => _concededgoals;
    public int Total => _total;

    public Team(string Name, int scoredgoals, int concededgoals)
    {
        this._name = Name;
        this._scoredgoals = scoredgoals;
        this._concededgoals = concededgoals;
        if (scoredgoals > concededgoals)
        {
            _total = 3;
        }
        else if (scoredgoals == concededgoals)
        {
            _total = 1;
        }
        else
        {
            _total = 0;
        }
    }

    public string PrintTeamInfo()
    {
        return $"{Name}: {Total} очков";
    }
}

class Program
{
    static void Main()
    {
        Team[] teams = new Team[5];
        teams[0] = new Team("Wolves", 3, 1);
        teams[1] = new Team("Tigers", 2, 2);
        teams[2] = new Team("Bears", 0, 1);
        teams[3] = new Team("Bulldogs", 3, 2);
        teams[4] = new Team("Chempions", 3, 3);

        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {

                if (teams[i].Total < teams[j].Total)
                {
                    Team temp = teams[i];
                    teams[i] = teams[j];
                    teams[j] = temp;
                }
                else if (teams[i].Total == teams[j].Total)
                {
                    int diff1 = teams[i].scoredgoals - teams[i].concededgoals;
                    int diff2 = teams[j].scoredgoals - teams[j].concededgoals;
                    if (diff1 < diff2)
                    {
                        Team temp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Таблица результатов:");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].PrintTeamInfo()}");
        }
    }
}