using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
    class Program
    {
        public struct Results
        {
            private string surname;
            private double res1;
            private double res2;
            private double res3;
            private double maxres;

            public string Surname => surname;
            public double Res1 => res1;
            public double Res2 => res2;
            public double Res3 => res3;

            public double Maxres
            {
                get { return maxres; }
                set { maxres = value; }
            }

            public Results(string surname, double res1, double res2, double res3, double maxres)
            {
                this.surname = surname;
                this.res1 = res1;
                this.res2 = res2;
                this.res3 = res3;
                this.maxres = maxres;
            }

            public void Print()
            {
                Console.WriteLine("Фамилия {0}   \t {1} ", surname, maxres);
            }

            public static double Bestres(Results results)
            {
                double best = Math.Max(Math.Max(results.Res1, results.Res2), results.Res3);
                return best;
            }
        }

        static void Main(string[] args)
        {
            Results[] res = new Results[5];
            res[0] = new Results("Иванов", 1.2, 1.4, 1.1, 0);
            res[1] = new Results("Петров", 2.2, 2.1, 2.8, 0);
            res[2] = new Results("Сидоров", 2.5, 1.9, 2.1, 0);
            res[3] = new Results("Смирнов", 1.9, 1.8, 2.0, 0);
            res[4] = new Results("Васечкин", 2.7, 2.9, 1.8, 0);

            for (int i = 0; i < res.Length; i++)
            {
                res[i].Maxres = Results.Bestres(res[i]);
                res[i].Print();
            }
            Console.ReadKey();
        }
    }
}
