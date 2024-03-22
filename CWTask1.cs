using System;

struct Rectangle
{
    private double Length;
    private double Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateS()
    {
        return Length * Width;
    }

    public double CalculateP()
    {
        return 2 * (Length + Width);
    }

    public void Compare(Rectangle otherRectangle)
    {
        Console.WriteLine("Results:");
        Console.WriteLine(" ");

        Console.WriteLine("Rectangle A - Length: " + Length + ", Width: " + Width);
        Console.WriteLine("Rectangle B - Length: " + otherRectangle.Length + ", Width: " + otherRectangle.Width);

        if (Length > otherRectangle.Length)
            Console.WriteLine("Rectangle A is longer than Rectangle B.");
        else
            Console.WriteLine("Rectangle A is shorter than Rectangle B.");

        if (Width > otherRectangle.Width)
            Console.WriteLine("Rectangle A is wider than Rectangle B.");
        else
            Console.WriteLine("Rectangle A is narrower than Rectangle B.");

        if (CalculateS() > otherRectangle.CalculateS())
            Console.WriteLine("Rectangle A has a greater area.");
        else
            Console.WriteLine("Rectangle B has a greater area.");

    }
}

class Program
{
    static void Main()
    {
        Rectangle[] rectangle = new Rectangle[3];

        rectangle[0] = new Rectangle(5, 10);
        rectangle[1] = new Rectangle(8, 6);
        rectangle[2] = new Rectangle(7, 9);

        Console.WriteLine("Rectangle Comparison:");
        Console.WriteLine(" ");

        for (int i = 0; i < rectangle.Length; i++)
        {
            for (int j = i + 1; j < rectangle.Length; j++)
            {
                Console.WriteLine($"Comparing Rectangle {i + 1} = Rectangle A and Rectangle {j + 1} = Rectangle B:");
                rectangle[i].Compare(rectangle[j]);
                Console.WriteLine();
            }
        }
    }
}