using System;

namespace lab2n2
{
    struct Jumps
    {
        private string _surname;
        private double _res1;
        private double _res2;
        private double _res3;
        public double bestres;
        public Jumps(string surname, double res1, double res2, double res3)
        {
            _surname = surname;
            _res1 = res1;
            _res2 = res2;
            _res3 = res3;
            bestres = 0;
        }
        public double res1 => _res1;
        public double res2 => _res2;
        public double res3 => _res3;
        public void Print()
        {
            Console.WriteLine("{0,-7} | {1,-3}", _surname, bestres);
        }
    }
    internal class Program
    {
        static void bestof3(Jumps[] contestants)
        {
            
            for(int i = 0; i < contestants.Length; i++)
            {

                if(contestants[i].res1 > contestants[i].res2)
                {
                    if (contestants[i].res1 > contestants[i].res3)
                    {
                      
                        contestants[i].bestres = contestants[i].res1;
                    }
                    else
                    {
                        contestants[i].bestres = contestants[i].res3;
                    }
                }
                else
                {
                    if (contestants[i].res2 > contestants[i].res3)
                    {

                        contestants[i].bestres = contestants[i].res2;
                    }
                    else
                    {
                        contestants[i].bestres = contestants[i].res3;
                    }
                }

            }
            
        }
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

            
            bestof3(contestants);
            Console.WriteLine("Сортированный список");
            for (int i = 0; i < contestants.Length; i++)
            {
                contestants[i].Print();
            }
        }
    }
}
