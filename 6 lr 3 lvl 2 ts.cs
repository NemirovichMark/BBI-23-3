
using System;
using System.Drawing;
using System.Text.RegularExpressions;

struct FootBall
{
    private string team_;
    private int point_;
    public  int point => point_;
    public FootBall(string team, int point)
    {
    team_ = team;
    point_ = point;
    }
    public void Printinf()
    {
        Console.WriteLine(
        "команда {0} \t очки {1}", team_, point_);
    }
}
class Program
{
    static void Main(string[] args)
    {
        FootBall[] group1 = new FootBall[]
            {
            new FootBall ("Форвард", 11),
            new FootBall("Темп", 17),
            new FootBall("Лис", 9),
            new FootBall("Орел", 10),
            new FootBall("Тула", 15),
            new FootBall("Авангард", 6),
            new FootBall("Динамо", 13),
            new FootBall("Югра", 12),
            new FootBall("Ритм", 8),
            new FootBall("Скорость", 14),
            new FootBall("Снайперы", 7),
            new FootBall("Космос", 6),
            };
        FootBall[] group2 = new FootBall[]
            {
            new FootBall ("Авто", 9),
            new FootBall("Даль", 13),
            new FootBall("Кот", 11),
            new FootBall("Арес", 18),
            new FootBall("Спартак", 17),
            new FootBall("Ястреб", 6),
            new FootBall("Мотор", 10),
            new FootBall("Снег", 7),
            new FootBall("Ашан", 8),
            new FootBall("Трактор", 14),
            new FootBall("Мяч", 12),
            new FootBall("Комета", 6),
            };
        static void SortByTeam(FootBall[] group1)
        {
            for (int i = 0; i < group1.Length; i++)
            {
                for (int j = i + 1; j < group1.Length; j++)
                {
                    if (group1[i].point < group1[j].point)
                    {
                        FootBall tewmp = group1[j];
                        group1[j] = group1[i];
                        group1[i] = tewmp;
                    }
                }
            }
        }
        SortByTeam(group2);
        SortByTeam(group1);

        for (int i = 0; i < 12; i++)
        {
            group1[i].Printinf();
        }
        Console.WriteLine();
        for (int i = 0; i < 12; i++)
        {
            group2[i].Printinf();
        }
        FootBall[] rez = new FootBall[12];
        
        for (int i = 0; i < 6; i++)
        {
            rez[i] = group1[i];
        }
        
        for (int i = 0; i < 6; i++)
        {
            rez[i+6] = group2[i];
        }
        SortByTeam(rez);
        Console.WriteLine();
        Console.WriteLine("Окончательный список команд: ");

        for (int i = 0; i < 12; i++)
        {
            rez[i].Printinf();
        }
    }
}
