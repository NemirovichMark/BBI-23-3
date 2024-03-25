class Athlete
{
    protected string _name;
    protected int _score;
    public int Score => _score;
    public Athlete(string name, int score)
    {
        _name = name;
        _score = score;
    }
    public virtual void Print()
    {
        Console.WriteLine("{0,-7} | {1,-3} | ", _name, _score);
    }
}
class SkierMan : Athlete
{
    public SkierMan(string name, int score) : base(name, score)
    {

    }
    public override void Print()
    {
        Console.WriteLine("Лыжники {0,-7} | {1,-3} |  ", _name, _score);
    }
}
class SkierWoman : Athlete
{
    public SkierWoman(string name, int score) : base(name, score) { }
    public override void Print()
    {
        Console.WriteLine("Лыжницы {0,-7} | {1,-3}  ", _name, _score);
    }
}
internal class Program
{
    static void ArrayPrint(Athlete[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].Print();
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        SkierWoman[] womanGr1 = new SkierWoman[5] {
            new SkierWoman("Лена",30),
            new SkierWoman("Анна",25),
            new SkierWoman("Дина",40),
            new SkierWoman("Ольга",30),
            new SkierWoman("Данна",27)
        };
        SkierWoman[] womanGr2 = new SkierWoman[5] {
            new SkierWoman("Едизавета",28),
            new SkierWoman("Варвара",29),
            new SkierWoman("Анастасия",44),
            new SkierWoman("София",34),
            new SkierWoman("Ксения",32)
        };
        SkierMan[] manGr1 = new SkierMan[5] {
            new SkierMan("Андрей",25),
            new SkierMan("Артем",28),
            new SkierMan("Илья",40),
            new SkierMan("Даниил",32),
            new SkierMan("Михаил",30)
        };
        SkierMan[] manGr2 = new SkierMan[5] {
            new SkierMan("Виталий",30),
            new SkierMan("Амир",32),
            new SkierMan("Армен",38),
            new SkierMan("Григорий",40),
            new SkierMan("Глеб",30)
        };
        ArrayPrint(womanGr1);
        ArrayPrint(womanGr2);
        ArrayPrint(manGr1);
        ArrayPrint(manGr2);
        SkierWoman[] women = new SkierWoman[10];
        for (int i = 0; i < 5; i++)
        {
            women[i] = womanGr1[i];
            women[i + 5] = womanGr2[i];
        }
        SkierMan[] men = new SkierMan[10];

        for (int i = 0; i < 5; i++)
        {
            men[i] = manGr1[i];
            men[i + 5] = manGr2[i];
        }
        ArrayPrint(women);
        ArrayPrint(men);
        Console.WriteLine();
        Athlete[] athletes = new Athlete[20];
        for (int i = 0; i < 10; i++)
        {
            athletes[i] = men[i];
            athletes[i + 10] = women[i];

        }

        ArrayPrint(athletes);





    }
}