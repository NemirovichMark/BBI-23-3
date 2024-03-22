using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Book
    {
        protected string title;
        protected int isbn;
        protected string author;
        protected int year;
        protected double price;

        public Book(string title, int isbn, string author, int year, double price)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.year = year;
            this.price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Название: {0}", title);
            Console.WriteLine("ISBN: {0}", isbn);
            Console.WriteLine("Автор: {0}", author);
            Console.WriteLine("Год издания: {0}", year);
            Console.WriteLine("Цена: {0}", price);
            Console.WriteLine();
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetYear()
        {
            return year;
        }

        public abstract double CalculatePrice()
        ;
    }

    class PaperBook : Book
    {
        private bool hardCover;

        public PaperBook(string title, int isbn, string author, int year, double price, bool hardCover) : base(title, isbn, author, year, price)
        {
            this.hardCover = hardCover;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Твердый переплет: {0}", hardCover ? "Да" : "Нет");
        }

        public override double CalculatePrice()
        {
            return price * 1.2;
        }
    }

    class ElectronicBook : Book
    {
        private string format;

        public ElectronicBook(string title, int isbn, string author, int year, double price, string format) : base(title, isbn, author, year, price)
        {
            this.format = format;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Формат: {0}", format);
        }

        public override double CalculatePrice()
        {
            return price * 0.8;
        }
    }

    class AudioBook : Book
    {
        private bool studioRecording;

        public AudioBook(string title, int isbn, string author, int year, double price, bool studioRecording) : base(title, isbn, author, year, price)
        {
            this.studioRecording = studioRecording;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Студийная запись: {0}", studioRecording ? "Да" : "Нет");
        }

        public override double CalculatePrice()
        {
            return price * 0.9;
        }
    }

    class Program
    {
        static void Main()
        {
            PaperBook[] paperBooks = new PaperBook[]
            {
            new PaperBook("Бумажная книга1", 111, "Автор1", 2000, 20.5, true),
            new PaperBook("Бумажная книга2", 222, "Автор2", 1996, 18.75, false),
            new PaperBook("Бумажная книга3", 333, "Автор3", 2010, 23.0, true),
            new PaperBook("Бумажная книга4", 444, "Автор4", 1985, 15.25, false),
            new PaperBook("Бумажная книга5", 555, "Автор5", 2021, 27.99, true)
            };

            ElectronicBook[] electronicBooks = new ElectronicBook[]
            {
            new ElectronicBook("Электронная книга1", 101, "Автор1", 2005, 15.99, "pdf"),
            new ElectronicBook("Электронная книга2", 202, "Автор2", 1999, 12.5, "fb2"),
            new ElectronicBook("Электронная книга3", 303, "Автор3", 2014, 17.0, "epub"),
            new ElectronicBook("Электронная книга4", 404, "Автор4", 1989, 10.75, "pdf"),
            new ElectronicBook("Электронная книга5", 505, "Автор5", 2018, 20.25, "fb2")
            };

            AudioBook[] audioBooks = new AudioBook[]
            {
            new AudioBook("Аудиокнига1", 1111, "Автор1", 2008, 22.0, true),
            new AudioBook("Аудиокнига2", 2222, "Автор2", 1995, 18.5, false),
            new AudioBook("Аудиокнига3", 3333, "Автор3", 2012, 25.75, true),
            new AudioBook("Аудиокнига4", 4444, "Автор4", 1980, 14.99, false),
            new AudioBook("Аудиокнига5", 5555, "Автор5", 2016, 19.99, true)
            };
            Console.WriteLine("   Бумажные книги   ");
            PaperBook[] sortedPaperBooks = Sort(paperBooks);
            foreach (var book in sortedPaperBooks)
            {
                book.DisplayInfo();
            }

            Console.WriteLine("   Электронные книги   ");
            ElectronicBook[] sortedElectronicBooks = Sort(electronicBooks);
            foreach (var book in sortedElectronicBooks)
            {
                book.DisplayInfo();
            }

            Console.WriteLine("   Аудиокниги   ");
            var sortedAudioBooks = Sort(audioBooks);
            foreach (var book in sortedAudioBooks)
            {
                book.DisplayInfo();
            }

        }

        static T Sort<T>(T array) where T : Book
        {
            T temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].Price < array[j + 1].Price)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }

}
