using System;

namespace lab2n2
{
    struct Jumps
    {
        private string _surname;
        private double _res1;
        private double _res2;
        private double _res3;
        private double _bestres;
        

        public Jumps(string surname, double res1, double res2, double res3)
        {
            _surname = surname;
            _res1 = res1;
            _res2 = res2;
            _res3 = res3;
            if (res1 > res2)
            {
                if (res1 > res3)
                {

                    _bestres = res1;
                }
                else
                {
                    _bestres = res3;
                }
            }
            else
            {
                if (res2 > res3)
                {

                    _bestres = res2;
                }
                else
                {
                    _bestres = res3;
                }
            }
            _bestres = bestres;
        }
        public double res1 => _res1;
        public double res2 => _res2;
        public double res3 => _res3;
        public double bestres => _bestres;
        public void Print()
        {
            Console.WriteLine("{0,-7} | {1,-3}", _surname, bestres);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Jumps[] contestants = new Jumps[5]
            {
                new Jumps("Ivanov", 1, 4, 5),
                new Jumps("Petrov", 2, 2.5, 7),
                new Jumps("White", 3, 4, 6),
                new Jumps("Grey", 3, 2, 4),
                new Jumps("Black", 7, 9, 6)
            };
            Console.WriteLine("Сортированный список");
            for (int i = 0; i < contestants.Length; i++)
            {
                contestants[i].Print();
            }
        }
    }
}
