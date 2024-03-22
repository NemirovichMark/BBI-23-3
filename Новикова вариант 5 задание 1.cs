using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Book
    {
        private string title;
        private int isbn;
        private string author;
        private int year;

        public Book(string title, int isbn, string author, int year)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Название: {0}", title);
            Console.WriteLine("ISBN: {0}", isbn);
            Console.WriteLine("Автор: {0}", author);
            Console.WriteLine("Год издания: {0}", year);
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
    }

    class Program
    {
        static void Main()
        {
            Book[] books = new Book[10];

            books[0] = new Book("Книга1", 12345, "Автор1", 2000);
            books[1] = new Book("Книга2", 32135, "Автор2", 1990);
            books[2] = new Book("Книга3", 94135, "Автор3", 1987);
            books[3] = new Book("Книга4", 38635, "Автор4", 1902);
            books[4] = new Book("Книга5", 32005, "Автор5", 2007);
            books[5] = new Book("Книга6", 32609, "Автор1", 2022);
            books[6] = new Book("Книга7", 32905, "Автор2", 1901);
            books[7] = new Book("Книга8", 98679, "Автор3", 1900);
            books[8] = new Book("Книга9", 84782, "Автор4", 1970);
            books[9] = new Book("Книга10", 30981, "Автор5", 1940);

            Console.WriteLine("Все книги:");
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }

            Console.Write("Введите имя автора: ");
            string authorName = Console.ReadLine();
            Console.WriteLine("Книги автора {0}:", authorName);
            foreach (Book book in books)
            {
                if (book.GetAuthor() == authorName)
                {
                    book.DisplayInfo();
                }
            }

            Console.Write("Введите век: ");
            int century = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Книги из {0} века:", century);
            foreach (Book book in books)
            {
                if ((book.GetYear() / 100) + 1 == century)
                {
                    book.DisplayInfo();
                }
            }
        }

    }
}
