using System;
using System.Collections.Generic;

struct Series
{
    public string title;
    public int avgDuration;
    public string description;
    public bool watched;

    public Series(string title, int avgDuration)
    {
        this.title = title;
        this.avgDuration = avgDuration;
        this.description = $"Для сериала {title} описание не задано";
        this.watched = false;
    }

    public void ChangeDescription(string newDescription)
    {
        if (newDescription.Length >= 20 && newDescription.Length <= 200)
        {
            description = newDescription;
            Console.WriteLine("Описание успешно изменено.");
        }
        else
        {
            Console.WriteLine("Описание должно содержать от 20 до 200 символов.");
        }
    }

    public void ChangeWatchedState()
    {
        watched = true;
        Console.WriteLine($"Сериал {title} отмечен как просмотренный.");
    }

    public void GetInfo()
    {
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Средняя длительность серии: {avgDuration}");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine($"Просмотрен: {watched}");
    }
}

class Program
{
    static void Main()
    {
        Series[] seriesList = {
            new Series("Воронины", 60),
            new Series("Счастливы вместе", 50),
            new Series("Друзья", 25),
            new Series("Теория большого взрыва", 45),
            new Series("Молодежка", 55)
        };

        Array.Sort(seriesList, (x, y) => x.title.CompareTo(y.title));

        Console.WriteLine("Название\tСредняя длительность серии\tОписание\t\tПросмотрен");
        foreach (var series in seriesList)
        {
            Console.WriteLine($"{series.title}\t\t{series.avgDuration}\t\t\t{series.description}\t{series.watched}");
        }
    }
}
