using System;

abstract class Game
{
    public abstract void StartGame(int min, int max);
}

class GuessGame : Game
{
    private int secretNumber;
    private bool numberGuessed;
    private int attempts;
    private int record;

    public override void StartGame(int min, int max)
    {
        if (max - min < 2 || min < 0 || max < 0)
        {
            Console.WriteLine("Число до должно быть хотя бы на 2 больше числа от и числа должны быть положительными.");
            return;
        }

        Random rand = new Random();
        secretNumber = rand.Next(min, max + 1);
        numberGuessed = false;
        attempts = 0;
        record = int.MaxValue;

        while (!numberGuessed)
        {
            Console.Write($"Угадайте число от {min} до {max}: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess == secretNumber)
            {
                numberGuessed = true;
                if (attempts < record)
                {
                    record = attempts;
                }
            }
            else
            {
                if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
        }

        Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
        Console.WriteLine($"Рекорд: {record} попыток.");
    }
}

class Program
{
    static void Main()
    {
        int min = 6;
        int max = 9;

        GuessGame game = new GuessGame();
        game.StartGame(min, max);
    }
}