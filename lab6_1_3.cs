using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_lev1_3
{
    struct Answers
    {
        public string surname;
        public int number;
        public Answers(string surname, int number)
        {
            this.surname = surname;
            this.number = number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Answers[] an = new Answers[8];
            an[0] = new Answers("Нагиев", 8);
            an[1] = new Answers("Ургант", 4);
            an[2] = new Answers("Малышева", 2);
            an[3] = new Answers("Пелевин", 10);
            an[4] = new Answers("Малахов", 7);
            an[5] = new Answers("Янковский", 5);
            an[6] = new Answers("Богомолов", 3);
            an[7] = new Answers("Пересильд", 1);
            double total = 0;
            for (int i = 0; i < an.Length; i++)
            {

                total += an[i].number;
                Console.WriteLine("Фамилия {0}  \t {1} голосов", an[i].surname, an[i].number);
            }

            for (int i = 0; i < an.Length - 1; i++)
            {
                int amax = an[i].number;
                int imax = i;
                for (int j = i + 1; j < an.Length; j++)
                {
                    if (an[j].number > amax)
                    {
                        amax = an[j].number;
                        imax = j;
                    }
                }
                Answers temp;
                temp = an[imax];
                an[imax] = an[i];
                an[i] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                double part = (an[i].number / total) * 100;
                Console.WriteLine("Фамилия {0}   \t {1} голосов \t доля {2}%", an[i].surname, an[i].number, part);
            }
            Console.ReadKey();

        }
    }
}
