using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace новикова_лаба_6_уровень_1
{
    struct Participant
    {
        private string surname;
        private string society;
        private int result1;
        private int result2
        ;

        public Participant
        (string sur, string soc, int r1, int r2)
        {
            surname = sur;
            society = soc;
            result1 = r1;
            result2 = r2;
        }

        public string Surname
        {
            get { return surname; }
        }
        public string Society
        {
            get { return society; }
        }
        public int FirstAttempt
        {
            get { return result1; }
        }
        public int SecondAttempt
        {
            get { return result2; }
        }

        public int TotalScore
        {
            get { return result1 + result2; }
        }

        public void Print()
        {
            Console.WriteLine("Фамилия {0}   \t {1} общество \t\t {2}  {3}", surname, society, result1, result2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Participant[] participant = new Participant[4]
            {
                new Participant("Иванова","Общество A",5,4),
                new Participant("Петрова","Общество B",4,6),
                new Participant("Зайцева","Общество A",6,8),
                new Participant("Симонова","Общество C",5,5)
            };

            for (int i = 0; i < participant.Length - 1; i++)
            {
                for (int j = 0; j < participant.Length - i - 1; j++)
                {
                    if (participant[j].TotalScore < participant[j + 1].TotalScore)
                    {
                        Participant temp = participant[j];
                        participant[j] = participant[j + 1];
                        participant[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
               
                participant[i].Print();
            }
        }
    }
}
