using System;
struct Cross
{
    private string famile_;
    private int group_;
    private string trener_;
    private double rez_;
    public string norm;
    public double rez => rez_;

    public Cross(string famile, int group, string trener, double rez)
    {
        famile_ = famile;
        group_ = group;
        trener_ = trener;
        norm = "NULL";
        rez_ = rez;
    }
    public void Printinf()
    {
        Console.WriteLine(
        "Фамилия {0} \t Группа {1} \t Тренер {2} \t Результат {3:f2} \t {4}",
        famile_, group_, trener_, rez_, norm);
    }
}

class Program
{
    static void Main()
    {
        Cross[] sp = new Cross[5]
        {
            new Cross("Макеева", 5, "Грачев", 55.2),
                new Cross("Щербакова", 1, "Калодко", 63.3),
                new Cross("Минина", 4, "Табулина", 58.9),
                new Cross("Акинина ", 6, "Ермакова", 57.5),
                new Cross("Рыбина", 2, "Бычков", 60.7)

        };


        static void SortByNorm(Cross[] sp)
        {
            for (int i = 0; i < sp.Length - 1; i++)
            {
                for (int j = i + 1; j < sp.Length; j++)
                {
                    if (sp[j].rez < sp[i].rez)
                    {
                        Cross temp = sp[j];
                        sp[j] = sp[i];
                        sp[i] = temp;
                    }
                }
            }
        }
        int k = 0;
        for (int i = 0; i < 5; i++)
        {
            if (sp[i].rez < 60)
            {
                sp[i].norm = "Сдала";
                k++;
            }
            else sp[i].norm = "Не сдала";
        }
        SortByNorm(sp);
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            sp[i].Printinf();
        }
        Console.WriteLine();
        Console.WriteLine("Количество людей сдавщих норматив: {0}", k);

    }
}