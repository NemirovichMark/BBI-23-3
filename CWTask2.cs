using System;
using System.Collections.Generic;

abstract class Watching
{
    public string title;
    public string description;
    public bool watched;

    public Watching(string title)
    {
        this.title = title;
        this.description = $"Для фильма {title} описание не задано";
        this.watched = false;
    }
    public:
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

    }
    class Movie : Watching
{
    public int ageRating;
    public int duration;

    public Movie(string title, int ageRating, int duration) : base(title)
    {
        this.ageRating = ageRating;
        this.duration = duration;
    }
}

class Program
{
    static void Main()
    {
        Movie[] moviesList = {
            new Movie("Inception", 16, 148),
            new Movie("The Godfather", 18, 175),
            new Movie("The Shawshank Redemption", 15, 142),
            new Movie("Pulp Fiction", 18, 154),
            new Movie("Forrest Gump", 12, 142),
        };

        Watching[] watchingList = new Watching[] {
            new Series("Игра престолов", 60),
            new Series("Рик и Морти", 50),
            new Movie("Крестный отец", 16, 148),
            new Movie("Мгла", 18, 175),
            new Movie("Зеленая миля", 15, 142)
        };

        foreach (var item in watchingList)
        {
            if (item is Series)
            {
                if (item.title == "Game of Thrones" || item.title == "Breaking Bad")
                {
                    item.ChangeWatchedState();
                }
            }
            else if (item is Movie)
            {
                if (item.title == "Inception" || item.title == "The Godfather" || item.title == "The Shawshank Redemption")
                {
                    item.ChangeWatchedState();
                }
            }
        }

        Array.Sort(watchingList, (x, y) => x.title.CompareTo(y.title));

        Console.WriteLine("Название\tСредняя длительность серии/длительность фильма\tОписание\tПросмотрен");
        foreach (var item in watchingList)
        {
            if (item.watched)
            {
                string duration = item is Series ? ((Series)item).avgDuration.ToString() : ((Movie)item).duration.ToString();
                Console.WriteLine($"{item.title}\t\t{duration}\t\t\t{item.description}\t{item.watched}");
            }
        }
    }
}
