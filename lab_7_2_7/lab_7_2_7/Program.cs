
class Human
{
    protected string _name;
    protected int _wincount;
    protected double _drawcount;
    protected int _loosecount;
    protected double _finalscore;
    public Human(string name, int wins, double draws, int looses)
    {
        _name = name;
        _wincount = wins;
        _drawcount = draws;
        _loosecount = looses;
        _finalscore = wins * 1 + draws / 2;
    }
    public double Finalscore => _finalscore;
    public virtual void Print()
    {
        // name не больше 5 символов иначе вывод ломаесться
        Console.WriteLine("{0,-5} | {1,-3} | {2,-3} | {3,-7} | {4,-3}", _name, _wincount, _drawcount, _loosecount, _finalscore);
    }
}
class Athlete : Human
{
    static int _id = 0;
    private int ID;
    public Athlete(string name, int wins, double draws, int looses) : base(name, wins, draws, looses)
    {
        _id++;
        ID = _id;
    }
    public override void Print()
    {
        Console.WriteLine("{5,-3} | {0,-5} | {1,-3} | {2,-3} | {3,-7} | {4,-3}", _name, _wincount, _drawcount, _loosecount, _finalscore, ID);
    }

}

internal class Program
{

        static void Sort(Human[] participants)
        {
            int i = 1;
            int j = i + 1;
            while (i < participants.Length)
            {
                if (participants[i].Finalscore < participants[i - 1].Finalscore)
                {
                    i = j;
                    j++;
                }
                else
                {
                    Human temp = participants[i];
                    participants[i] = participants[i - 1];
                    participants[i - 1] = temp;
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
            Athlete[] participants = new Athlete[6]
            {
            new Athlete("Kolin", 3,2,5),
            new Athlete("Dima", 4,0,6),
            new Athlete("Lima", 8,2,0),
            new Athlete("Mila", 5,2,3),
            new Athlete("Glina", 6,3,1),
            new Athlete("Isaac", 3,3,4)
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