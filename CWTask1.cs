using System;

struct GuessGame
{
    private int secretNumber;
    private bool numberGuessed;
    private int attempts;
    private int record;

    public void Game()
    {
        secretNumber = new Random().Next(0, 11);
        numberGuessed = false;
        attempts = 0;
        record = int.MaxValue;
    }

    public void StartGame()
    {
        while (!numberGuessed)
        {
            Console.Write("Угадайте число от 0 до 10: ");
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
        GuessGame game = new GuessGame();
        game.Game();
        game.StartGame();
    }
}