using System;
using System.Collections.Generic;

public abstract class Animal
{
    public string Name { get; set; }
    public string FoodType { get; set; }

    public Animal(string name, string foodType)
    {
        Name = name;
        FoodType = foodType;
    }

    public abstract void MakeSound();

    public void PrintInfo()
    {
        Console.WriteLine($"Животное: {Name}, Тип питания: {FoodType}, Звук:");
        MakeSound();
    }
}

public class Giraffe : Animal
{
    public Giraffe(string name) : base(name, "Травоядное") { }

    public override void MakeSound()
    {
        Console.WriteLine("Муу");
    }
}

public class Pig : Animal
{
    public Pig(string name) : base(name, "Всеядное") { }

    public override void MakeSound()
    {
        Console.WriteLine("Хрю");
    }
}


class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Giraffe("Жираф 1"),
            new Giraffe("Жираф 2"),
            new Giraffe("Жираф 3"),
            new Pig("Свинья 1"),
            new Pig("Свинья 2"),
            new Pig("Свинья 3"),
        };

        Console.WriteLine("Травоядные:");
        PrintCategory(animals, "Травоядное");
        Console.WriteLine("\nХищные:");
        PrintCategory(animals, "Хищник");
        Console.WriteLine("\nВсеядные:");
        PrintCategory(animals, "Всеядное");
    }

    static void PrintCategory(Animal[] animals, string foodType)
    {
        foreach (Animal animal in animals)
        {
            if (animal.FoodType == foodType)
            {
                animal.PrintInfo();
                Console.WriteLine();
            }
        }
        Console.ReadKey();  
    }
}

