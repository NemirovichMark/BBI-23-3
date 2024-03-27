using System;
using System.Collections.Generic;

struct Dot
{
    public int x;
    public int y;
    public int z;
}

struct Vector
{
    public Dot Point1;
    public Dot Point2;

    public Vector(int[,] matrix)
    {
        Point1 = new Dot { x = matrix[0, 0], y = matrix[0, 1], z = matrix[0, 2] };
        Point2 = new Dot { x = matrix[1, 0], y = matrix[1, 1], z = matrix[1, 2] };
    }

    public double CalculateLength()
    {
        int dx = Point2.x - Point1.x;
        int dy = Point2.y - Point1.y;
        int dz = Point2.z - Point1.z;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Координаты первой точки: ({0}, {1}, {2}", Point1.x, Point1.y, Point1.z);
        Console.WriteLine("Координаты второй точки: ({0}, {1}, {2}", Point2.x, Point2.y, Point2.z);
        Console.WriteLine("Длина вектора: {0}", CalculateLength());
        Console.WriteLine();
    }
}
class Programm
{
    static void Main()
    {
        Vector[] vectors = new Vector[5];
        vectors[0] = new Vector(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
        vectors[1] = new Vector(new int[,] { { 2, 3, 4 }, { 5, 6, 7 } });
        vectors[2] = new Vector(new int[,] { { 3, 4, 5 }, { 6, 7, 8 } });
        vectors[3] = new Vector(new int[,] { { 4, 5, 6 }, { 7, 8, 9 } });
        vectors[4] = new Vector(new int[,] { { 5, 6, 7 }, { 8, 9, 10 } });

        Array.Sort(vectors, (v1, v2) => v2.CalculateLength().CompareTo(v1.CalculateLength()));

        foreach (var vector in vectors)
        {
            vector.PrintInfo();
        }
    }
}
