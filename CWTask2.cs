using System;

abstract class Embrasure
{
    protected string Name;
    protected double Width;
    protected double Length;
    protected double Thickness;

    public Embrasure(string name, double width, double length, double thickness)
    {
        Name = name;
        Width = width;
        Length = length;
        Thickness = thickness;
    }

    public abstract double CalculateInstallationCost();
}

class Window : Embrasure
{
    private int NumberOfLayers;

    public Window(string name, double width, double length, double thickness, int numberOfLayers): base(name, width, length, thickness)
    {
        NumberOfLayers = numberOfLayers;
    }

    public override double CalculateInstallationCost()
    {
        return Width * Length * Thickness * NumberOfLayers * 20;
    }
}

class Door : Embrasure
{
    private bool Pattern;
    private bool Glass;

    public Door(string name, double width, double length, double thickness, bool pattern, bool glass): base(name, width, length, thickness)
    {
        Pattern = pattern;
        Glass = glass;
    }

    public override double CalculateInstallationCost()
    {
        double cost = Width * Length * Thickness * 30;

        if (Pattern)
        {
            cost += 100;
        }
        if (Glass)
        {
            cost += 200;
        }

        return cost;
    }
}

class Program
{
    static void Main()
    {
        Embrasure[] embrasures = new Embrasure[10];

        for (int i = 0; i < embrasures.Length - 1; i++)
        {
            for (int j = i + 1; j < embrasures.Length; j++)
            {
                if (embrasures[i].CalculateInstallationCost() > embrasures[j].CalculateInstallationCost())
                {
                    Embrasure temp = embrasures[i];
                    embrasures[i] = embrasures[j];
                    embrasures[j] = temp;
                }
            }
        }

        Console.WriteLine("Windows:");
        Console.WriteLine("  ");
        foreach (var item in embrasures)
        {
            if (item is Window)
            {
                Console.WriteLine($"{item.Name,-10} {item.Width,-10} {item.Length,-10} {item.Thickness,-10} {item.CalculateInstallationCost()}");
            }
        }

        Console.WriteLine("Doors:");
        Console.WriteLine("  ");
        foreach (var item in embrasures)
        {
            if (item is Door)
            {
                Console.WriteLine($"{item.Name,-10} {item.Width,-10} {item.Length,-10} {item.Thickness,-10} {item.CalculateInstallationCost()}");
            }
        }
    }
}
