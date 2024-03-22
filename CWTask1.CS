using System;

public struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int[] coordinates)
    {
        X = coordinates[0];
        Y = coordinates[1];
    }

    public double CalculateDistance(Point otherPoint)
    {
        return Math.Sqrt(Math.Pow(X - otherPoint.X, 2) + Math.Pow(Y - otherPoint.Y, 2));
    }

    public static void PrintPointInfo(Point point1, Point point2)
    {
        Console.WriteLine(" Point 1: ({0}, {1})  Point 2: ({2}, {3})  Distance: {4:F2} ",
                          point1.X, point1.Y, point2.X, point2.Y, point1.CalculateDistance(point2));
    }
}

class Program
{
    static void Main()
    {
        Point[] points = new Point[3];
        points[0] = new Point(new int[] { 1, 2 });
        points[1] = new Point(new int[] { 3, 4 });
        points[2] = new Point(new int[] { 5, 6 });

        Console.WriteLine(" Point Pair       Distance    ");


        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Point.PrintPointInfo(points[i], points[j]);
            }
        }
    }
}
