
namespace number1
{



    public struct Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }



        public double Area()
        {
            return length * width;
        }



        public double Perimeter()
        {
            return 2 * (length + width);
        }



        public void Compare(Rectangle other)
        {
            Console.WriteLine($"Сравнение прямоугольников:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Rectangle 1: {length} x {width}");
            Console.WriteLine($"Rectangle 2: {other.length} x {other.width}");

            if (length > other.length)
                Console.WriteLine("Первый прямоугольник больше по длине.");
            else if (length < other.length)
                Console.WriteLine("Второй прямоугольник больше по длине .");
            else
                Console.WriteLine(" Прямоугольники одиноковой длинны .");

            if (width > other.width)
                Console.WriteLine("Первый прямоугольник шире .");
            else if (width < other.width)
                Console.WriteLine(" Второй прямоугольник шире .");
            else
                Console.WriteLine(" Прямоугольники одинаковые по ширине.");

            double area1 = Area();
            double area2 = other.Area();

            if (area1 > area2)
                Console.WriteLine("Первый прямоугольник больше по площади .");
            else if (area1 < area2)
                Console.WriteLine("Второй прямоугольник больше по площади.");
            else
                Console.WriteLine(" Прямоугольники одинаковой площади.");
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle1 = new Rectangle(5, 10);
            Rectangle rectangle2 = new Rectangle(8, 6);
            Rectangle rectangle3 = new Rectangle(7, 7);

            CompareRectangles(rectangle1, rectangle2);
            Console.WriteLine();

            CompareRectangles(rectangle1, rectangle3);
            Console.WriteLine();

            CompareRectangles(rectangle2, rectangle3);
        }

        static void CompareRectangles(Rectangle rect1, Rectangle rect2)
        {
            rect1.Compare(rect2);
            Console.WriteLine();
        }
    }

}









