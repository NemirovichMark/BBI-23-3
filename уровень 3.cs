struct Exams
{
    private string _group;
    private int _ex1;
    private int _ex2;
    private int _ex3;
    private int _ex4;
    private int _ex5;
    private double _finalscore;
    public Exams(string group, int ex1, int ex2, int ex3, int ex4, int ex5)
    {
        _group = group;
        _ex1 = ex1;
        _ex2 = ex2;
        _ex3 = ex3;
        _ex4 = ex4;
        _ex5 = ex5;
        _finalscore = (ex1 + ex2 + ex3 + ex4 + ex5) / 5;
    }
    public double Finalscore => _finalscore;
    public void Print()
    {

        Console.WriteLine(_group + "        " + _ex1 + "         " + _ex2 + "          " + _ex3 + "         " + _ex4 + "          " + _ex5 + "         " + _finalscore);
    }
}
internal class Program
{
    static void Sort(Exams[] participants)
    {
        for (int i = 1; i < participants.Length; i++)
        {
            for (int j = 1; j < participants.Length; j++)
            {
                if (participants[j].Finalscore > participants[j - 1].Finalscore)
                {
                    Exams temp = participants[j];
                    participants[j] = participants[j - 1];
                    participants[j - 1] = temp;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Exams[] participants = new Exams[5]
        {
            new Exams("BBI-1", 78, 67, 56, 90, 82),
            new Exams("BBI-2", 64, 89, 51, 99, 88),
            new Exams("BBI-3", 76, 59, 81, 63, 75),
            new Exams("BBI-4", 93, 54, 59, 99, 52),
            new Exams("BBI-5", 86, 45, 76, 81, 86),

        };
        Sort(participants);
        Console.WriteLine("Список групп :");
        Console.WriteLine("Группа\t     Экзамен 1\t     Экзамен2\t     Экзамен3\t      Экзамен4\t       Экзамен5\t       Средний балл");
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Console.ReadKey();
    }
}
