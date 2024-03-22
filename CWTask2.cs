using System;

abstract class Profession
{
    private string Title;
    protected double ExperienceBonus;

    public abstract double CalculateSalary();

    public Profession(string title, double experienceBonus)
    {
        Title = title;
        ExperienceBonus = experienceBonus;
    }

    public string GetTitle()
    {
        return Title;
    }

    public static void GnomeSortBySalary(List<Profession> professions)
    {
        int i = 0;
        while (i < professions.Count)
        {
            if (i == 0 || professions[i].CalculateSalary() <= professions[i - 1].CalculateSalary())
            {
                i++;
            }
            else
            {
                Profession temp = professions[i];
                professions[i] = professions[i - 1];
                professions[i - 1] = temp;
                i--;
            }
        }
    }
}

class Fireman : Profession
{
    private double DangerBonus;

    public Fireman(string title, double experienceBonus, double dangerBonus) : base(title, experienceBonus)
    {
        DangerBonus = dangerBonus;
    }

    public override double CalculateSalary()
    {
        return 2000 + ExperienceBonus * 100 + DangerBonus * 500;
    }
}

class Engineer : Profession
{
    private int Category;

    public Engineer(string title, double experienceBonus, int category) : base(title, experienceBonus)
    {
        Category = category;
    }

    public override double CalculateSalary()
    {
        return 2500 + ExperienceBonus * 150 + Category * 300;
    }
}

class Scientist : Profession
{
    private string Degree;

    public Scientist(string title, double experienceBonus, string degree) : base(title, experienceBonus)
    {
        Degree = degree;
    }

    public override double CalculateSalary()
    {
        return 3000 + ExperienceBonus * 200 + (Degree == "PhD" ? 1000 : 500);
    }
}

class Program
{
    static void Main()
    {
        List<Profession> workers = new List<Profession>
        {
            new Fireman("Firefighter1", 15, 3),
            new Fireman("Firefighter2", 8, 4),
            new Fireman("Firefighter3", 11, 1),
            new Fireman("Firefighter4", 9, 9),
            new Fireman("Firefighter5", 7, 4),
            new Engineer("Engineer1", 11, 2),
            new Engineer("Engineer2", 19, 7),
            new Engineer("Engineer3", 15, 7),
            new Engineer("Engineer4", 13, 9),
            new Engineer("Engineer5", 11, 7),
            new Scientist("Researcher1", 15, "MSc"),
            new Scientist("Researcher2", 11, "PhD"),
            new Scientist("Professor1", 20, "PhD"),
            new Scientist("Professor2", 21, "PhD"),
            new Scientist("Professor3", 19, "MSc")
        };

        Profession.GnomeSortBySalary(workers);

        Console.WriteLine("Firemen:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Title", "Profession", "Salary");
        foreach (var worker in workers.FindAll(w => w is Fireman))
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", worker.GetTitle(), worker.GetType().Name, worker.CalculateSalary());
        }

        Console.WriteLine("\nEngineers:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Title", "Profession", "Salary");
        foreach (var worker in workers.FindAll(w => w is Engineer))
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", worker.GetTitle(), worker.GetType().Name, worker.CalculateSalary());
        }

        Console.WriteLine("\nScientists:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Title", "Profession", "Salary");
        foreach (var worker in workers.FindAll(w => w is Scientist))
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", worker.GetTitle(), worker.GetType().Name, worker.CalculateSalary());
        }

        Console.WriteLine("\nAll Professions:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Title", "Profession", "Salary");
        for (int i=0; i<workers.LongCount(); i++)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", workers[i].GetTitle(), workers[i].GetType().Name, workers[i].CalculateSalary());
        }
    }
}


