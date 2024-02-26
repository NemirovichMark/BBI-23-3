using System.Data;
using System.Security.Cryptography.X509Certificates;

struct SkiTournoment
{
    private string _name;
    private int[] _scoreList;
    public SkiTournoment(string name, int gr1score, int gr2score)
    {
        _name = name;
        _scoreList = new int[2] { gr1score, gr2score };
    }
    public int[] Score => _scoreList;
    public void Print()
    {
        // name не больше 5 символов иначе вывод ломаесться
        Console.WriteLine("{0,-5} | {1,-3} | {2,-3} ", _name, _scoreList[0], _scoreList[1] );
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        SkiTournoment[] participants = new SkiTournoment[5]
        {
            new SkiTournoment("Lenon", 20,21),
            new SkiTournoment("Leontev", 19,18),
            new SkiTournoment("Kirilov", 23,18),
            new SkiTournoment("Korotki", 17,19),
            new SkiTournoment("Bolshoi", 24,10)
        };
        Sort(participants,0);
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Sort(participants,1);
        Console.WriteLine();
        for (int i = 0; i < participants.Length; i++) 
        {
            participants[i].Print();
        }
        Console.WriteLine();
        SortFull(participants);
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Console.ReadKey();
    }
    static void SortFull(SkiTournoment[] participants)
    {
        int res1;
        int res2;
        for (int i = 1; i < participants.Length; i++)
        {
            for (int j = 1; j < participants.Length; j++)
            {
  

                if (participants[j].Score[0] > participants[j].Score[1])
                {
                    res1 = participants[j].Score[1];
                }
                else
                { 
                    res1= participants[j].Score[0];
                }

                if (participants[j-1].Score[0] > participants[j-1].Score[1])
                {
                    res2 = participants[j-1].Score[1];
                }
                else
                {
                    res2 = participants[j-1].Score[0];
                }
                if (res1 < res2)
                {
                    SkiTournoment temp = participants[j];
                    participants[j] = participants[j - 1];
                    participants[j - 1] = temp;
                }

            }
        }
    }
    static void Sort(SkiTournoment[] participants, int a)
    {
        int res1;
        int res2;
        for (int i = 1; i < participants.Length; i++)
        {
            for (int j = 1; j < participants.Length; j++)
            {
                res1 = participants[j].Score[a];
                res2 = participants[j-1].Score[a];

                if (res1 < res2)
                {
                    SkiTournoment temp = participants[j];
                    participants[j] = participants[j - 1];
                    participants[j - 1] = temp;
                }

            }
        }
    }
}
