using ConsoleApp3.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class program { }
    internal class list { }
    namespace Series
    {
        struct Series
        {
            public string Title { get; set; }
            public double AverageEpisodeLength { get; set; }
            public string Description { get; set; }
            public bool IsWatched { get; set; }

            public Series(string title, double averageEpisodeLength)
            {
                Title = title;
                AverageEpisodeLength = averageEpisodeLength;
                Description = $"Для сериала {Title} описание не задано.";
                IsWatched = false;
            }

            public void ChangeDescription(string newDescription)
            {
                if (newDescription.Length < 20 || newDescription.Length > 200)
                {
                    Console.WriteLine("Описание должно быть длиной от 20 до 200 символов.");
                }
                else
                {
                    Description = newDescription;
                }
            }

            public void ChangeWatchedStatus()
            {
                IsWatched = true;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Название: {Title}");
                Console.WriteLine($"Средняя продолжительность серии: {AverageEpisodeLength} минут");
                Console.WriteLine($"Описание: {Description}");
                Console.WriteLine($"Просмотрен: {IsWatched}");
                Console.WriteLine();
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        List seriesList = new List {
new Series("Игра престолов", 55),
new Series("Во все тяжкие", 45),
new Series("Друзья", 25),
new Series("Офис", 20),
new Series("Шерлок", 60)
};

        seriesList.Sort((s1, s2) => s1.Title.CompareTo(s2.Title));

        Console.WriteLine("Список сериалов:");
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        Console.WriteLine("| Название | Средняя продолжительность серии | Описание | Просмотрен |");
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        foreach (Series series in seriesList)
        {
            series.PrintInfo();
        }
    }
}
