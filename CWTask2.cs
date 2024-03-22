using System.Globalization;
using System.Reflection;
using System.Security.Claims;

abstract class Vehicle
{
    private string mark;
    private string model;
    private int VIM;
    public int year { get; private set; }
    private int prob;
    private string harakt = "";
    public Vehicle(string _mark, string _model, int _year, int _prob)
    {
        mark = _mark;
        model = _model;
        year = _year;
        prob = _prob;
        VIM = new Random().Next(1000, 9999);
    }
    public virtual void Printresult()
    {
        Console.WriteLine("{0,-18:s}{1,-18:s}{2,-18:f0}{3,-18:f0}{4,-18:f0}{5,-18:s}", mark, model, VIM, year, prob, harakt);
    }
    public void Harakt()
    {
        if
            ((prob / (2024 - year)) > 500) harakt = "рабочая";
        else if
            ((prob / (2024 - year)) < 100) harakt = "простаивающая";
        else
            harakt = "праздничная";
    }
}
class Cars : Vehicle
{
    private string Class;
    public Cars(string _brand, string _model, int _year, int _prob, string _class) : base(_brand, _model, _year, _prob)
    {
        Class = _class;
    }
    public override void Printresult()
    {
        base.Printresult();
        Console.Write("{0,-18:s}", Class);
    }
}
class Trucks : Vehicle
{
    private int kolesa;
    public Trucks(string _brand, string _model, int _year, int _prob, int _kolesa) : base(_brand, _model, _year, _prob)
    {
        kolesa = _kolesa;
    }
    public override void Printresult()
    {
        base.Printresult();
        Console.Write("{0,-18:f0}", kolesa);
    }
}
class Motorcycles : Vehicle
{
    public Motorcycles(string _brand, string _model, int _year, int _prob) : base(_brand, _model, _year, _prob) 
    { 
    }
}


class Program
{
    static void SortTransport(Vehicle[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            Vehicle k = array[i];
            int j = i - 1;
            while (j >= 0 && array[j].year < k.year)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = k;
        }
    }

    static void Main()
    {
        Cars[] cars =
        {
            new Cars("Lada", "Granta", 2011, 1500, "A"),
            new Cars("Niva", "Travel", 2002, 2150, "С"),
            new Cars("УАЗ", "Патриот", 2005, 8500, "S"),
            new Cars("ГАЗ", "Соболь NN", 2022, 1350, "B"),
            new Cars("Aurus", "Senat", 2018, 300, "S")
        };
        Trucks[] trucks =
        {
            new Trucks("Lada", "Granta", 2011, 1500, 8),
            new Trucks("Niva", "Travel", 2002, 2150, 4),
            new Trucks("УАЗ", "Патриот", 2005, 8500, 3),
            new Trucks("ГАЗ", "Соболь NN", 2022, 1350, 6),
            new Trucks("Aurus", "Senat", 2018, 300, 4)
        };
        Motorcycles[] motorcycles =
        {
            new Motorcycles("Lada", "Granta", 2011, 1500),
            new Motorcycles("Niva", "Travel", 2002, 2150),
            new Motorcycles("УАЗ", "Патриот", 2005, 8500),
            new Motorcycles("ГАЗ", "Соболь NN", 2022, 1350),
            new Motorcycles("Aurus", "Senat", 2018, 300)
        };
        SortTransport(cars);
        Console.WriteLine("{0,-18:s}{1,-18:s}{2,-18:f0}{3,-18:f0}{4,-18:f0}{5,-18:s}{6,-18:s}", "Марка", "Модель", "Номер VIM", "Год выпуска", "Пробег", "Характеристика", "Класс");
        foreach (Cars a in cars)
        {
            a.Harakt();
            a.Printresult();
            Console.WriteLine();
        }
        Console.WriteLine();
        SortTransport(trucks);
        Console.WriteLine("{0,-18:s}{1,-18:s}{2,-18:f0}{3,-18:f0}{4,-18:f0}{5,-18:s}{6,-18:f0}", "Марка", "Модель", "Номер VIM", "Год выпуска", "Пробег", "Характеристика", "Количество колёс");
        foreach (Trucks a in trucks)
        {
            a.Harakt();
            a.Printresult();
            Console.WriteLine();
        }
        Console.WriteLine();
        SortTransport(motorcycles);
        Console.WriteLine("{0,-18:s}{1,-18:s}{2,-18:f0}{3,-18:f0}{4,-18:f0}{5,-18:s}", "Марка", "Модель", "Номер VIM", "Год выпуска", "Пробег", "Характеристика");
        foreach (Motorcycles a in motorcycles)
        {
            a.Harakt();
            a.Printresult();
            Console.WriteLine();
        }
        Console.WriteLine();

        Vehicle[] array = new Vehicle[15];
        int i = 0;
        foreach (Cars a in cars) 
            array[i++] = a;
        foreach (Trucks a in trucks) 
            array[i++] = a;
        foreach (Motorcycles a in motorcycles) 
            array[i++] = a;
        SortTransport(array);
        Console.WriteLine("{0,-18:s}{1,-18:s}{2,-18:s}{3,-18:s}{4,-18:s}{5,-18:s}{6,-18:s}", "Марка", "Модель", "Номер VIM", "Год выпуска", "Пробег", "Характеристика", "Класс или количество колёс (если есть)");
        foreach (Vehicle a in array)
        {
            a.Harakt();
            a.Printresult();
            Console.WriteLine();
        };
    }
}