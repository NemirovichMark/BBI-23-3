using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ур_2_н_3
{
    class Program
    {
        struct Results
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
            public double Maxres => maxres;

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
                double best = Math.Max(Math.Max(res[i].Res1, res[i].Res2), res[i].Res3);
                Results result = new Results(res[i].Surname, res[i].Res1, res[i].Res2, res[i].Res3, best);
                result.Print();
            }
            Console.ReadKey();
        }
    }
}
