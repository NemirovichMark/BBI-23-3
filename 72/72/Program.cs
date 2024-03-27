using System;

public abstract class WinterSport
{
    public abstract string DisciplineName { get; }
}

public class FigureSkating : WinterSport
{
    public override string DisciplineName
    {
        get { return "Фигурное катание"; }
    }
}

public class SpeedSkating : WinterSport
{
    public override string DisciplineName
    {
        get { return "Конькобежный спорт"; }
    }
}

public class Participant
{
    private string Name;
    private double[] Scores;
    private int SumOfPlaces;

    public Participant(string name, double[] scores, int sum)
    {
        Name = name;
        Scores = scores;
        SumOfPlaces = sum;
    }

    public string GetName() => Name;
    public double[] GetScores() => Scores;
    public int GetSumOfPlaces() => SumOfPlaces;

    public void SetSumOfPlaces(int sum)
    {
        SumOfPlaces = sum;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        WinterSport[] sports = { new FigureSkating(), new SpeedSkating() };

        foreach (var sport in sports)
        {
            Console.WriteLine($"Название дисциплины: {sport.DisciplineName}");

            Participant[] participants = new Participant[5]
            {
                new Participant("Bob", new double[] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7 }, 0),
                new Participant("John", new double[] { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7 }, 0),
                new Participant("Leo", new double[] { 2.1, 2.2, 2.3, 2.4, 2.5, 2.6, 2.7 }, 0),
                new Participant("Mark", new double[] { 3.1, 3.2, 3.3, 3.4, 3.5, 3.6, 3.7 }, 0),
                new Participant("Kiril", new double[] { 4.1, 4.2, 4.3, 4.4, 4.5, 4.6, 4.7 }, 0)
            };

            for (int i = 0; i < participants.Length; i++)
            {
                for (int j = 0; j < participants[i].GetScores().Length; j++)
                {
                    int place = 1;
                    for (int k = 0; k < participants.Length; k++)
                    {
                        if (k != i && participants[i].GetScores()[j] < participants[k].GetScores()[j])
                        {
                            place++;
                        }
                    }
                    int b = participants[i].GetSumOfPlaces();
                    b += place;
                    participants[i].SetSumOfPlaces(b);
                }
            }

            var orderedParticipants = participants.OrderBy(p => p.GetSumOfPlaces());

            foreach (var participant in orderedParticipants)
            {
                Console.WriteLine($"Имя: {participant.GetName()}, Сумма: {participant.GetSumOfPlaces()}");
            }
        }
    }
}