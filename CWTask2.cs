using System;

abstract class Shape
{
    public abstract double Volume { get; }

    public abstract double CalculateVolume();

    public abstract void PrintInfo();
}

class Sphere : Shape
{
    public double Radius { get; }

    public override double Volume => CalculateVolume();

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public override double CalculateVolume()
    {
        return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Шар с радиусом {Radius}");
    }
}

class Cube : Shape
{
    public double SideLength { get; }

    public override double Volume => CalculateVolume();

    public Cube(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double CalculateVolume()
    {
        return Math.Pow(SideLength, 3);
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Куб со стороной {SideLength}");
    }
}

class Cylinder : Shape
{
    public double Radius { get; }
    public double Height { get; }

    public override double Volume => CalculateVolume();

    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }

    public override double CalculateVolume()
    {
        return Math.PI * Math.Pow(Radius, 2) * Height;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Цилиндр с радиусом {Radius} и высотой {Height}");
    }
}

class Program
{
    static void Main()
    {
        Shape[] spheres = new Shape[]
        {
            new Sphere(3),
            new Sphere(2),
            new Sphere(4),
            new Sphere(1),
            new Sphere(5)
        };

        Array.Sort(spheres, (s1, s2) => s2.Volume.CompareTo(s1.Volume));
        Console.WriteLine("Шары:");
        foreach (var sphere in spheres)
        {
            sphere.PrintInfo();
        }

        Shape[] cubes = new Shape[]
        {
            new Cube(3),
            new Cube(2),
            new Cube(4),
            new Cube(1),
            new Cube(5)
        };

        Array.Sort(cubes, (c1, c2) => c2.Volume.CompareTo(c1.Volume));
        Console.WriteLine("Кубы:");
        foreach (var cube in cubes)
        {
            cube.PrintInfo();
        }

        Shape[] cylinders = new Shape[]
        {
            new Cylinder(2, 4),
            new Cylinder(3, 5),
            new Cylinder(1, 3),
            new Cylinder(4, 6),
            new Cylinder(5, 7)
        };

        Array.Sort(cylinders, (c1, c2) => c2.Volume.CompareTo(c1.Volume));
        Console.WriteLine("Цилиндры:");
        foreach (var cylinder in cylinders)
        {
            cylinder.PrintInfo();
        }

        Shape[] allShapes = new Shape[spheres.Length + cubes.Length + cylinders.Length];
        spheres.CopyTo(allShapes, 0);
        cubes.CopyTo(allShapes, spheres.Length);
        cylinders.CopyTo(allShapes, spheres.Length + cubes.Length);

        Array.Sort(allShapes, (s1, s2) => s2.Volume.CompareTo(s1.Volume));
        Console.WriteLine("Все фигуры:");
        foreach (var shape in allShapes)
        {
            shape.PrintInfo();
        }
    }
}