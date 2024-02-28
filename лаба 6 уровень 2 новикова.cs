using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace новикова_лаба_6_уровень_2
{
    class Program
    {
        struct Participant
        {
            private string surname;
            private int res1;
            private int res2;
            private int res3;
            private int maxres;

            public Participant(string surname, int res1, int res2, int res3)
            {
                this.surname = surname;
                this.res1 = res1;
                this.res2 = res2;
                this.res3 = res3;
                this.maxres = this.maxres = Math.Max(Math.Max(res1, res2), res3); ;

            }

            public string Surname
            {
                get { return surname; }
            }

            public int Res1
            {
                get { return res1; }
            }

            public int Res2
            {
                get { return res2; }
            }

            public int Res3
            {
                get { return res3; }
            }
            public void Print()
            {

                Console.WriteLine("Фамилия {0}  \t {1}; {2}; {3}", surname, res1, res2, res3);
            }

            public int MaxRes
            {
                get { return maxres; }
            }
            public void MaxRes1()
            {
               
            }

        }

        static void Main(string[] args)
        {
            Participant[] participants = new Participant[5];

            participants[0] = new Participant("Козлов", 1, 1, 2);
            participants[1] = new Participant("Новиков", 2, 2, 3 );
            participants[2] = new Participant("Щербаков", 2, 2, 7);
            participants[3] = new Participant("Наумов", 1, 2, 2);
            participants[4] = new Participant("Блинов", 5, 2, 1);
            for (int i = 0; i < participants.Length - 1; i++)
            {
                for (int j = i + 1; j < participants.Length; j++)
                {
                    if (participants[j].MaxRes > participants[i].MaxRes)
                    {
                        Participant temp = participants[i];
                        participants[i] = participants[j];
                        participants[j] = temp;
                    }
                }
            }

            foreach (Participant p in participants)
            {
                p.Print();
            }
        }
    }
}
