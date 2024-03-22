using System;

abstract class Profession
{
    public string Name { get; set; }
    public double ExperienceBonus { get; set; }

    public abstract double CalculateSalary();

    public override string ToString()
    {
        return $"{Name}\t{CalculateSalary()}";
    }
}

class Fireman : Profession
{
    public double DangerBonus { get; set; }

    public Fireman(string name, double experienceBonus, double dangerBonus)
    {
        Name = name;
        ExperienceBonus = experienceBonus;
        DangerBonus = dangerBonus;
    }

    public override double CalculateSalary()
    {
        return 1000 + (ExperienceBonus * 100) + DangerBonus;
    }
}

class Engineer : Profession
{
    public string Category { get; set; }

    public Engineer(string name, double experienceBonus, string category)
    {
        Name = name;
        ExperienceBonus = experienceBonus;
        Category = category;
    }

    public override double CalculateSalary()
    {
        return 1500 + (ExperienceBonus * 150) + (Category == "First" ? 500 : 0);
    }
}

class Scientist : Profession
{
    public string Degree { get; set; }

    public Scientist(string name, double experienceBonus, string degree)
    {
        Name = name;
        ExperienceBonus = experienceBonus;
        Degree = degree;
    }

    public override double CalculateSalary()
    {
        return 2000 + (ExperienceBonus * 200) + (Degree == "PhD" ? 1000 : 0);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Profession[] allProfessions = new Profession[15];

        for (int i = 0; i < 5; i++)
        {
            allProfessions[i] = new Fireman("Fireman " + (i + 1), i + 1, 100);
            allProfessions[i + 5] = new Engineer("Engineer " + (i + 1), i + 1, "First");
            allProfessions[i + 10] = new Scientist("Scientist " + (i + 1), i + 1, "PhD");
        }

        Array.Sort(allProfessions, (x, y) => y.CalculateSalary().CompareTo(x.CalculateSalary()));

        Console.WriteLine("Firemen:");
        Console.WriteLine("Name\tSalary");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(allProfessions[i]);
        }

        Console.WriteLine("\nEngineers:");
        Console.WriteLine("Name\tSalary");
        for (int i = 5; i < 10; i++)
        {
            Console.WriteLine(allProfessions[i]);
        }

        Console.WriteLine("\nScientists:");
        Console.WriteLine("Name\tSalary");
        for (int i = 10; i < 15; i++)
        {
            Console.WriteLine(allProfessions[i]);
        }

        Array.Sort(allProfessions, (x, y) => y.CalculateSalary().CompareTo(x.CalculateSalary()));

        Console.WriteLine("\nAll Professions Combined:");
        Console.WriteLine("Name\tSalary");
        foreach (var profession in allProfessions)
        {
            Console.WriteLine(profession);
        }
    }
}
