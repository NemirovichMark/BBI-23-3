struct Car
{
    private string _mark;
    private int _model;
    static int _VIMtr = 0;
    private int _VIM;
    private int _year;
    public int _probeg { get; private set; }
    private string _harck;
    public Car(string mark, int model, int year, int probeg)
    {
        _mark = mark;
        _model = model;
        _VIMtr++;
        _VIM = _VIMtr;
        _year = year;
        _probeg = probeg;
        _harck = "NULL";
        Haracter(probeg);
    }
    private void Haracter(int probeg)
    {
        if (probeg > 500)
        {
            _harck = "Work";
        }
        if (probeg <= 500 && probeg >= 100)
        {
            _harck = "PRasdnichay";
        }
        if (probeg < 100)
        {
            _harck = "Prostaivayshaya";
        }
    }
    public void Print()
    {
        Console.WriteLine($"{_mark}, {_model}, {_VIM}, {_year}, {_probeg}, {_harck}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[5]
        {
            new Car("1", 1, 2012, 560),
            new Car("2", 3, 2015, 98),
            new Car("3", 6, 1999, 200),
            new Car("4", 432, 2202, 100),
            new Car("5", 32, 2000, 500)
        };
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].Print();
        }
        Sort(cars);
        Console.WriteLine();
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].Print();
        }
        Console.ReadKey();
    }


    static void Sort(Car[] cars)
    {
        int d = cars.Length / 2;
        while (d >= 1)
        {
            for (int i = d; i < cars.Length; i++)
            {
                int j = i;
                var temp = cars[i];
                int x = cars[i]._probeg;
                while (j >= d && cars[j - d]._probeg > x)
                {

                    cars[j] = cars[j - d];
                    j -= d;

                }
                cars[j] = temp;


            }
            d /= 2;
        }
    }
}