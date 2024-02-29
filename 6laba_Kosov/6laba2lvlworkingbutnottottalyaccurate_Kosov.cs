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
        List<Player> players = new List<Player>()
        {
            new Player() { Name = "Krosh", PenaltyMins = 10 },
            new Player() { Name = "Pin", PenaltyMins = 5 },
            new Player() { Name = "Ezhik", PenaltyMins = 10 },
            new Player() { Name = "Losjash", PenaltyMins = 2 },
            new Player() { Name = "Kopatich", PenaltyMins = 5 },
            new Player() { Name = "Barash", PenaltyMins = 2 },
        };

        var candidates = players.Where(p => p.PenaltyMins != 10).OrderBy(p => p.PenaltyMins).ToList();

        foreach (var player in candidates)
        {
            Console.WriteLine($"{player.Name} - {player.PenaltyMins} мин");
        }
    }
}
