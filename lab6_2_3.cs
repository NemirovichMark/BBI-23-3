using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_lev2_3
{
    class Program
    {
        struct Results
        {
            public string surname;
            public double res1;
            public double res2;
            public double res3;
            public Results(string surname, double res1, double res2, double res3)
            {
                this.surname = surname;
                this.res1 = res1;
                this.res2 = res2;
                this.res3 = res3;
            }
        }
        static void Main(string[] args)
        {
            Results[] res = new Results[5];
            res[0] = new Results("Иванов", 1.2, 1.4, 1.1);
            res[1] = new Results("Петров", 2.2, 2.1, 2.8);
            res[2] = new Results("Сидоров", 2.5, 1.9, 2.1);
            res[3] = new Results("Смирнов", 1.9, 1.8, 2.0);
            res[4] = new Results("Васечкин", 2.7, 2.9, 1.8);

            for (int i = 0; i < res.Length; i++)
            {

                Console.WriteLine("Фамилия {0}  \t {1}; {2}; {3}", res[i].surname, res[i].res1, res[i].res2, res[i].res3);
            }

            Console.WriteLine();
            for (int i = 0; i < res.Length; i++)
            {
                double best = Math.Max(Math.Max(res[i].res1, res[i].res2), res[i].res3);
                Console.WriteLine("Фамилия {0}   \t {1} ", res[i].surname, best);
            }
            Console.ReadKey();

        }
    }
}
