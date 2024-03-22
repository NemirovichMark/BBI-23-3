using System;

struct Point
{
    private int X;
    private int Y;

    public Point(int[] coordinates)
    {
        X = coordinates[0];
        Y = coordinates[1];
    }

    public double DistanceTo(Point dist)
    {
        return Math.Sqrt(Math.Pow(dist.X - X, 2) + Math.Pow(dist.Y - Y, 2));
    }

    public void DisplayInfo(Point other)
    {
        double distance = DistanceTo(other);
        Console.WriteLine("Точка 1: X = {0}, Y = {1}", X, Y);
        Console.WriteLine("Точка 2: X = {0}, Y = {1}", other.X, other.Y);
        Console.WriteLine("Расстояние между точками: {0:F2}", distance);
        Console.WriteLine();
    }

    public int GetX()
    {
        return X;
    }

    public int GetY()
    {
        return Y;
    }
}

class Program
{
    static void Main()
    {
        Point[] points = new Point[3];
        points[0] = new Point(new int[] { 0, 0 });
        points[1] = new Point(new int[] { 4, 4 });
        points[2] = new Point(new int[] { -5, -1 });

        for (int i = 0; i < points.Length - 1; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                points[i].DisplayInfo(points[j]);
            }
        }
    }
}


