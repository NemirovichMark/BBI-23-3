using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;



namespace ConsoleApp5

{

    class GuessGame

    {

        private Int32 record;
        private Int32 currentNumber;

        public GuessGame(Int32 newNumber)

        {
          record = Int32.MaxValue;
          currentNumber = newNumber;

        }

        public void game()

        {

            Int32 select = -100;
            Int32 cnt = 0;

            while (select != currentNumber)

            {
             Console.Write("Введите число: ");

               select = Convert.ToInt32(Console.ReadLine());

                if (select != currentNumber)

                {
                 Console.WriteLine("Это не то число.");
                 }

                cnt += 1;

            }
             if (record > cnt)

            {
              Console.WriteLine("Новый рекорд");
              record = cnt;

            }

            gameover();

        }

        void gameover()

        {
         Console.WriteLine("Игра окончена");
         Console.WriteLine("Загаданное число: {0}", currentNumber);
         Console.WriteLine("Рекорд: {0}", record);
         Console.WriteLine("Попробовать снова?");

        }

    }
       class Program

    {
        static void Main(string[] args)

        {
         Random rand = new Random();
         Console.WriteLine("Добро пожаловать в игру");
         Console.WriteLine("Хотите ли сыграть в угадай число?");


         string select = Console.ReadLine();

        while (select == "да")

            {
               GuessGame g = new GuessGame(rand.Next(0, 10));
               g.game();
               select = Console.ReadLine();

            }



        }

    }

}


