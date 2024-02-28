using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab6_lev1_3
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
                Console.WriteLine("Фамилия {0}   \t {1} ", surname, best);
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
                double best = Math.Max(Math.Max(res[i].res1, res[i].res2), res[i].res3);
                Results result = new Results(res[i].surname, res[i].res1, res[i].res2, res[i].res3, best);
                result.Print();
            }
            Console.ReadKey();
        }
    }
}

}
