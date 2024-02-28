struct ChessTournoment
{
    private string _surname;
    private int _wins;
    private double _drawns;
    private int _loose;
    private double _finalscore;
    public ChessTournoment(string surname, int wins, double draws, int looses)
    {
        _surname = surname;
        _wins = wins;
        _drawns = draws;
        _loose = looses;
        _finalscore = wins + draws / 2;
    }
    public double Finalscore => _finalscore;
    public void Print()
    {
        
        Console.WriteLine( _surname + "        " +  _wins + "         " + _drawns + "          " +  _loose + "          " + _finalscore);
    }
}
internal class Program
{
    static void Sort(ChessTournoment[] participants)
    {
        for (int i = 1; i < participants.Length; i++)
        {
            for (int j = 1; j < participants.Length; j++)
            {
                if (participants[j].Finalscore > participants[j - 1].Finalscore)
                {
                    ChessTournoment temp = participants[j];
                    participants[j] = participants[j - 1];
                    participants[j - 1] = temp;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        ChessTournoment[] participants = new ChessTournoment[5]
        {
            new ChessTournoment("Ptichin", 3, 7, 0),
            new ChessTournoment("Zhuravlev", 1, 4, 5),
            new ChessTournoment("Abricosov", 6, 2, 2),
            new ChessTournoment("Volcov", 7, 0, 3),
            new ChessTournoment("Sobakevich", 10 , 0, 0),
        };
        Sort(participants);
        Console.WriteLine("Список участников :");
        Console.WriteLine("Фамилия\t     Победы\t     Ничьи\t     Поражения\t       Итог");
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Console.ReadKey();
    }
}
