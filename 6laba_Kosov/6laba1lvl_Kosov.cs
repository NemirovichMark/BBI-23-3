using System;
using System.Collections.Generic;
using System.Linq;

public class Jumper
{
    public string Name { get; private set; }
    public string Club { get; private set; }

    public int FirstTry { get; private set; }
    public int SecondTry { get; private set; }

    // Конструктор с параметрами для инициализации свойств
    public Jumper(string name, string club, int firstTry, int secondTry)
    {
        Name = name;
        Club = club;
        FirstTry = firstTry;
        SecondTry = secondTry;
    }


    public void DisplayInfo()
    {
        Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", Place, this.Name, this.Club, this.FirstTry, this.SecondTry);
    }


    public int TotalScore
    {
        get { return FirstTry + SecondTry; }
    }


    public int Place { get; internal set; }
}

class Program
{
    static void Main()
    {
        List<Jumper> jumpers = new List<Jumper>
        {
            new Jumper("Jesse Pinkman", "LosPolos", 10, 12),
            new Jumper("Walter White", "Hermanos", 15, 10)
        };

        var orderedJumpers = jumpers.OrderByDescending(j => j.TotalScore).ToList();

        // Назначить начальное место для всех прыгунов
        for (int i = 0; i < orderedJumpers.Count; i++)
        {
            orderedJumpers[i].Place = i + 1;
        }


        Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", "Место", "Имя", "Клуб", "Первая попытка", "Вторая попытка");


        foreach (var jumper in orderedJumpers)
        {
            jumper.DisplayInfo();
        }

    }
}   
