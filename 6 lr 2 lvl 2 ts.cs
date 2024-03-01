
using System;

struct Exam
{
    private string famile_;
    private double math_;
    private double phi_;
    private double rus_;
    private double sred_;
    public double sred => sred_;

    public Exam(string famile, double x, double y, double z)
    {
        famile_ = famile;
        math_ = x;
        phi_ = y;
        rus_ = z;
        if (math_ > 2 && rus_ > 2 && phi_ > 2)
        {
            sred_ = (math_ + phi_ + rus_) / 3;
        }
        else
        {
            sred_ = 0;
        }
    }


    public void PrintSred()
    {
        Console.WriteLine("Фамилия {0}\t Средний балл {1,4:f2}", famile_, sred_);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Exam[] cl = new Exam[5];
        cl[0] = new Exam("Веров", 4, 2, 4);
        cl[1] = new Exam("Гостев", 5, 5, 5);
        cl[2] = new Exam("Емелин", 3, 4, 3);
        cl[3] = new Exam("Фролов", 4, 5, 3);
        cl[4] = new Exam("Горбачев", 2, 3, 3);

        static void SortBySred( Exam[] cl)
        {
            for (int i = 0; i < cl.Length - 1; i++)
            {
                for (int j = i + 1; j < cl.Length; j++)
                {
                    if (cl[j].sred > cl[i].sred)
                    {
                        Exam temp = cl[j];
                        cl[j] = cl[i];
                        cl[i] = temp;
                    }
                }
            }
        }

        SortBySred(cl);

        for (int i = 0; i < 5; i++)
        {
            cl[i].PrintSred();
        }


        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            if (cl[i].sred != 0)
            {
                cl[i].PrintSred();
            }
        }
    }


}