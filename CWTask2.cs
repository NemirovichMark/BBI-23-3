using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            namespace WatchingApp
    {
        public abstract class Watching
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }

            public Watching(string title, string description, string status)
            {
                Title = title;
                Description = description;
                Status = status;
            }
        }

        public class Movie : Watching
        {
            public int AgeRating { get; set; }
            public int Duration { get; set; }

            public Movie(string title, string description, string status, int ageRating, int duration) : base(title, description, status)
            {
                AgeRating = ageRating;
                Duration = duration;
                Description = $"Для фильма {Title} описание не задано";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
               
                List watchings = new List {
new Movie("Фильм 1", "Описание фильма 1", "Не просмотрен", 10, 124),
new Movie("Фильм 2", "Описание фильма 2", "Просмотрен", 14, 110),
new Movie("Фильм 3", "Описание фильма 3", "Не просмотрен", 19, 181),
new Movie("Фильм 4", "Описание фильма 4", "Просмотрен", 15, 120),
new Movie("Фильм 5", "Описание фильма 5", "Не просмотрен", 16, 130)
};

                watchings.Sort((x, y) => x.Title.CompareTo(y.Title));

                
                Console.WriteLine("Список фильмов:");
            Console.WriteLine("-");
        }
    }



