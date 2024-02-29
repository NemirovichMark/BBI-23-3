

Код не компилируется. Ошибка в строке 29, пишет о перегрузке. С двумя переменными в массиве все работает, с тремя - нет.


/*


using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; set; }
    public int PenaltyMins { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Player> players = new List<Player>();
        // Создаем объект Random для генерации случайных чисел
        Random rand = new Random();


        for (int i = 1; i <= 30; i++)
        {

            players.Add(new Player { Name = $"Player{i}", PenaltyMins = rand.Next(2, 5, 10) });
        }


        players.RemoveAll(player => player.PenaltyMins == 10);


        players = players.OrderBy(player => player.PenaltyMins).ToList();


        foreach (var player in players)
        {
            Console.WriteLine($"Name: {player.Name}, Penalty Mins: {player.PenaltyMins}");
        }
    }
}