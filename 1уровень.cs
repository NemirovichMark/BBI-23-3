struct Survey
{
    private string _name;
    private string _surname;
    private double _quantity;
    private double _procent;
    public double Procent => _procent; // read-only property
    public double Quantity => _quantity; // read-only property
    public Survey(string name, string surname, double quantity)
    {
        double s = 1000;//Кол-во опрошенных
        _name = name;
        _surname = surname;
        _quantity = quantity;
        _procent = (quantity / s) * 100;

    }

    public void Print()
    {
        Console.WriteLine(_name + "     " + _surname + "          " + _quantity + "          "+ _procent);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Survey[] surveys = new Survey[7]
        {
            new Survey("Ivan", "Ivanov", 250),
            new Survey("Vladimir", "Putin", 328),
            new Survey("Alexander", "Pupkin", 105),
            new Survey("Valentin", "Budeyko", 160),
            new Survey("Mikhail", "Kuznetsov", 57),
            new Survey("Kirill", "Smirnov", 37),
            new Survey("Konstantin", "Lebedev", 63),
        };

        Sort(surveys);
        Console.WriteLine("Результирующая таблица:");
        Console.WriteLine("Имя\t Фамилия\t Голоса\t Проценты");
        for (int i = 0; i < 5; i++)
        {
            surveys[i].Print();
        }
        Console.ReadKey();

    }
    static void Sort(Survey[] Surveys)
    {
        for (int i = Surveys.Length - 1; i > 0; i--)
        {
            for (int j = Surveys.Length - 1; j > 0; j--)
            {
                if (Surveys[j].Quantity > Surveys[j - 1].Quantity)
                {
                    Survey temp = Surveys[j];
                    Surveys[j] = Surveys[j-1];
                    Surveys[j-1] = temp;
                }



            }
        }


    }
    
}