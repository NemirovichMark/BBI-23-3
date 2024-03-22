
using System;

struct Cars
{
    private string mark;
    private string model;
    private int VIM;
    private int year;
    public int prob { get; private set; }
    private string harakt = "";
    public Cars(string _mark, string _model, int _year, int _prob)
    {
        mark = _mark;
        model = _model;
        year = _year;
        prob = _prob;
        VIM = new Random().Next(1000, 9999);
    }
    public void Printresult()
    {
        Console.WriteLine("{0,-12:s}{1,-12:s}{2,-12:f0}{3,-12:f0}{4,-12:f0}{5,-12:s}", mark, model, VIM, year, prob, harakt);
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

class Program
{

    static void Main()
    {
        Cars[] cars =
        {
            new Cars("Lada", "Granta", 2011, 1500),
            new Cars("Niva", "Travel", 2002, 2150),
            new Cars("УАЗ", "Патриот", 2005, 8500),
            new Cars("ГАЗ", "Соболь NN", 2022, 1350),
            new Cars("Aurus", "Senat", 2018, 300)
        };
        Sortcars(cars);
        Console.WriteLine("{0,-12:s}{1,-12:s}{2,-12:f0}{3,-12:f0}{4,-12:f0}{5,-12:s}", "Марка", "Модель", "Номер VIM", "Год выпуска", "Пробег", "Характеристика");
        foreach (Cars a in cars)
        {
            a.Harakt();
            a.Printresult();
        }
    }
    static void Sortcars(Cars[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            Cars k = array[i];
            int j = i - 1;
            while (j >= 0 && array[j].prob < k.prob)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = k;
        }
    }
}