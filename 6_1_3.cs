using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab6_lev1_3
{
    struct Answers
    {
        private string surname1;
        private int number1;
        private double total;

        public string Surname => surname1;
        public int Number => number1;

        public Answers(string surname, int number, double total)
        {
            surname1 = surname;
            number1 = number;
            this.total = total;
        }

        public void Print()
        {
            Console.WriteLine("Фамилия {0}   \t {1} голосов \t доля {2}%", surname1, number1, (number1 / total) * 100);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Answers[] an = new Answers[8];
            an[0] = new Answers("Нагиев", 8, 0);
            an[1] = new Answers("Ургант", 4, 0);
            an[2] = new Answers("Малышева", 2, 0);
            an[3] = new Answers("Пелевин", 10, 0);
            an[4] = new Answers("Малахов", 7, 0);
            an[5] = new Answers("Янковский", 5, 0);
            an[6] = new Answers("Богомолов", 3, 0);
            an[7] = new Answers("Пересильд", 1, 0);
            double total = 0;

            for (int i = 0; i < an.Length; i++)
            {
                total += an[i].Number;
            }

            for (int i = 0; i < an.Length - 1; i++)
            {
                int amax = an[i].Number;
                int imax = i;
                for (int j = i + 1; j < an.Length; j++)
                {
                    if (an[j].Number > amax)
                    {
                        amax = an[j].Number;
                        imax = j;
                    }
                }
                Answers temp;
                temp = an[imax];
                an[imax] = an[i];
                an[i] = temp;
            }

            for (int i = 0; i < 5; i++)
            {
                an[i] = new Answers(an[i].Surname, an[i].Number, total);
                an[i].Print();
            }

            Console.ReadKey();
        }
    }

}
