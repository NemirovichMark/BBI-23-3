using System;

struct Competition
{
    private string _Surname;
    private int[] _Scores;
    private int Distance;
    public int[] Scores => _Scores;
    public string Surname => _Surname;

    public Competition(string surname, int[] scores, int distance)
    {
        _Surname = surname;
        _Scores = scores;
        Distance = distance;
    }

    public int CalculateTotalScore()
    {
        Array.Sort(_Scores);
        int totalStyleScore = 0;

        for (int i = 1; i < Scores.Length - 1; i++)
        {
            totalStyleScore += Scores[i];
        }

        int distanceScore = 60 + (Distance - 120) * 2;
        return totalStyleScore + distanceScore;
    }
}

class Program
{
    static void Main()
    {
        Competition[] competitors = new Competition[]
        {
            new Competition("Ivanov", new int[] { 5, 15, 7, 20, 3 }, 125),
            new Competition("Putin", new int[] {14, 18, 19, 20, 17}, 155),
            new Competition("Pupkin", new int[] { 10, 8, 9, 20, 16 }, 100),
            new Competition("Budeyko", new int[] { 1, 14, 13, 18, 9 }, 110),
            new Competition("Kuznetsov", new int[] { 4, 16, 18, 12, 11 }, 120),
        };

        Array.Sort(competitors, (x, y) => y.CalculateTotalScore().CompareTo(x.CalculateTotalScore()));

        Console.WriteLine("Итоговая таблица соревнований:");
        Console.WriteLine("Место\tФамилия\t\tБаллы");

        for (int i = 0; i < competitors.Length; i++)
        {
            Console.WriteLine($"{i + 1}\t{competitors[i].Surname}\t\t{competitors[i].CalculateTotalScore()}");
        }
    }
}