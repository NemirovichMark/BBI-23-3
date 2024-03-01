using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; private set; }
    public int PenaltyMins { get; set; }

    public Player(string name, int penaltyMins)
    {
        Name = name;
        PenaltyMins = penaltyMins;
    }
}

public class Program
{
    public static void PrintPlayers(IEnumerable<Player> players)
    {
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name} - {player.PenaltyMins} мин");
        }
    }

    public static void Main()
    {
        List<Player> players = new List<Player>()
        {
            new Player("Krosh", 10),
            new Player("Pin", 5),
            new Player("Ezhik", 10),
            new Player("Losjash", 2),
            new Player("Kopatich", 5),
            new Player("Barash", 2),
        };

        var candidates = players.Where(p => p.PenaltyMins != 10).OrderBy(p => p.PenaltyMins).ToList();

        PrintPlayers(candidates);
    }
}
