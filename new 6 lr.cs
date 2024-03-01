
    using System;
struct Cross
{
    private string famile_;
    private int group_;
    private string trener_;
    private double rez_;
    private string norm_;
    public static int k { get; private set; }
    public double rez => rez_;
    public string norm => norm_;


    public Cross(string famile, int group, string trener, double rez, string norm)
        {
            famile_ = famile;
            group_ = group;
            trener_ = trener;
            rez_ = rez;
            norm_ = norm;
             if (rez_ < 60)
            {
                norm_ = "Сдала";
                k++;
            }
            else norm_ = "Не сдала";
    }



        public void Printinf()
        {
            Console.WriteLine(
            "Фамилия {0} \t Группа {1} \t Тренер {2} \t Результат {3:f2} \t {4} ",
            famile_, group_, trener_, rez_, norm_);
    }




    }

class Program
{
    static void Main()
    {
        Cross[] sp = new Cross[5]
        {
                new Cross("Макеева", 5, "Грачев", 55.2, " "),
                    new Cross("Щербакова", 1, "Калодко", 63.3, " "),
                    new Cross("Минина", 4, "Табулина", 58.9, " "),
                    new Cross("Акинина ", 6, "Ермакова", 57.5, " "),
                    new Cross("Рыбина", 2, "Бычков", 60.7, " ")

        };
        int k = Cross.k;


        static void SortByNorm(Cross[] sp)
        {
            int i = 1;
            int j = i + 1;
            while (i < sp.Length)
            {
                if (sp[i - 1].rez < sp[i].rez)
                {
                    i = j;
                    j++;
                }
                else
                    {
                        Cross temp = sp[i-1];
                        sp[i-1] = sp[i];
                        sp[i] = temp;
                        i--;
                    }
            }
                    
             
        }


        SortByNorm(sp);

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            sp[i].Printinf();
        } 
        Console.WriteLine();

        Console.WriteLine(k);
    }
   
}

       
