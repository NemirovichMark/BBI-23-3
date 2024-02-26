
struct ChessTournoment
{
    private string _name;
    private int _wincount;
    private double _drawcount;
    private int _loosecount;
    private double _finalscore;
    public ChessTournoment(string name, int wins, double draws, int looses)
    {
        _name = name;
        _wincount = wins;
        _drawcount = draws;
        _loosecount = looses;
        _finalscore = wins * 1 + draws / 2;
    }
    public double Finalscore => _finalscore;
    public void Print()
    {
        // name не больше 5 символов иначе вывод ломаесться
        Console.WriteLine("{0,-5} | {1,-3} | {2,-3} | {3,-7} | {4,-3}", _name, _wincount, _drawcount, _loosecount, _finalscore);
    }
}
internal class Program
{
    static void Sort(ChessTournoment[] participants)
    {
        int i = 1;
        int j = i+1;
        while (i < participants.Length) 
        {
            if (participants[i].Finalscore < participants[i-1].Finalscore)
            {
                i=j;
                j++;
            }
            else
            {
                ChessTournoment temp = participants[i];
                participants[i]= participants[i-1];
                participants[i-1]= temp;
                i--;
                if (i == 0) 
                {
                    i = j;
                    j++;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        ChessTournoment[] participants = new ChessTournoment[6]
        {
            new ChessTournoment("Kolin", 3,2,5),
            new ChessTournoment("Dima", 4,0,6),
            new ChessTournoment("Lima", 8,2,0),
            new ChessTournoment("Mila", 5,2,3),
            new ChessTournoment("Glina", 6,3,1),
            new ChessTournoment("Isaac", 3,3,4)
        };

        Console.WriteLine("Список участников");
        Console.WriteLine("Имя   Победы Ничьи Поражения Результат");
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Sort(participants);
        Console.WriteLine("Sorted");
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Console.ReadKey();
    }
}
