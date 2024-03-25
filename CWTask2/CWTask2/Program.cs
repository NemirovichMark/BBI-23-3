using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

abstract class Vehicale
{
    protected string _mark;
    protected int _model;
    static int _VIMtr = 0;
    protected int _VIM;
    protected int _probeg;
    public int _year { get; protected set; }
    protected string _harck;
    public Vehicale(string mark, int model, int year, int probeg)
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
    protected void Haracter(int probeg)
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
    public virtual void Print()
    {
        Console.WriteLine($"{_mark}, {_model}, {_VIM}, {_year}, {_probeg}, {_harck}");
    }
}
class Car : Vehicale
{
    private string _clas;
    public Car(string clas, string mark, int model, int year, int probeg) : base(mark, model, year, probeg)
    {
        _clas = clas;

    }
    public override void Print()
    {
        Console.WriteLine($"{_mark}, {_model}, {_VIM}, {_year}, {_probeg}, {_harck}, {_clas}");
    }
}
class Truck : Vehicale
{
    private int _whellC;
    public Truck(string mark, int model, int year, int probeg) : base(mark, model, year, probeg)
    {
        _whellC = 4;
    }
    public override void Print()
    {
        Console.WriteLine($"{_mark}, {_model}, {_VIM}, {_year}, {_probeg}, {_harck}, {_whellC}");
    }
}
class Motorcycle : Vehicale
{
    private int _whellC;
    public Motorcycle(string mark, int model, int year, int probeg) : base(mark, model, year, probeg)
    {
        _whellC = 2;
    }
    public override void Print()
    {
        Console.WriteLine($"{_mark}, {_model}, {_VIM}, {_year}, {_probeg}, {_harck}, {_whellC}");
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[5]
        {
            new Car("A","Car1", 1, 2012, 560),
            new Car("B", "Car2", 3, 2015, 98),
            new Car("B", "Car3", 6, 1999, 200),
            new Car("A", "Car4", 432, 2202, 100),
            new Car("C", "Car5", 32, 2000, 500)
        };
        Truck[] trucks = new Truck[5] {
            new Truck("Tuck1", 21, 2012,1500),
            new Truck("Tuck2", 12, 2013,500),
            new Truck("Tuck3", 78, 2024,5540),
            new Truck("Tuck4", 1, 2090,90),
            new Truck("Tuck5", 90, 2002,100),
        };
        Motorcycle[] motorcycles = new Motorcycle[5] {
            new Motorcycle("Motorcycle1", 43, 2013, 400),
            new Motorcycle("Motorcycle2", 44, 2023, 90),
            new Motorcycle("Motorcycle3", 45, 2024, 5000),
            new Motorcycle("Motorcycle4", 47, 2010, 4000),
            new Motorcycle("Motorcycle5", 50, 2009, 300),
        };




        Sort(cars);
        Sort(trucks);
        Sort(motorcycles);
        Console.WriteLine();
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].Print();
        }
        Console.WriteLine();
        for (int i = 0; i < cars.Length; i++)
        {
            trucks[i].Print();
        }
        Console.WriteLine();
        for (int i = 0; i < cars.Length; i++)
        {
            motorcycles[i].Print();
        }
        Console.WriteLine();
        int a = motorcycles.Length + trucks.Length + cars.Length;
        Vehicale[] vechicals = new Vehicale[a];
        for (int i = 0; i < 5; i++)
        {
            vechicals[i] = cars[i];
            vechicals[i + 5] = trucks[i];
            vechicals[i + 10] = motorcycles[i];
        }
        Sort(vechicals);
        for (int i = 0; i < a; i++)
        {
            vechicals[i].Print();
        }
    }


    static void Sort(Vehicale[] cars)
    {
        int d = cars.Length / 2;
        while (d >= 1)
        {
            for (int i = d; i < cars.Length; i++)
            {
                int j = i;
                var temp = cars[i];
                int x = cars[i]._year;
                while (j >= d && cars[j - d]._year > x)
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
