struct Participant
{
private string _surname;
private string _community;
private int _result1;
private int _result2;

public int Result2 => _result2; // read-only property
public int Result1 => _result1; // read-only property
public Participant(string surname, string community, int result1, int result2)
{
    _surname = surname;
    _community = community;
    _result1 = result1;
    _result2 = result2;
}
public void Print()
{
    Console.WriteLine("{0,-7} | {1,-8} | {2,-16} | {3,-2} ", _surname, _community, _result1, _result2);
}
}
internal class Program
{
    static void Main(string[] args)
    {
        Participant[] participants = new Participant[5]
        {
            new Participant("Lenon", "pus", 20,21),
            new Participant("Leontev", "dus", 19,18),
            new Participant("Kirilov", "bus", 23,18),
            new Participant("Korotki", "sus", 17,19),
            new Participant("Bolshoi", "gus", 24,10)
        };

        Sort(participants);
        Console.WriteLine("Места");
        Console.WriteLine("Фамилия | Общество | Первый Результат | Второй Результат");
        for (int i = 0; i < participants.Length; i++)
        {
            participants[i].Print();
        }
        Console.ReadKey();



    }
    static void Sort(Participant[] Participants)
    {
        for (int i = 1; i < Participants.Length; i++)
        {
            for (int j = 1; j < Participants.Length; j++)
            {
                int res1 = (Participants[j].Result1 + Participants[j].Result2);
                int res2 = (Participants[j - 1].Result1 + Participants[j - 1].Result2);
                if (res1 < res2)
                {
                    Participant temp = Participants[j];
                    Participants[j] = Participants[j - 1];
                    Participants[j - 1] = temp;
                }
            }
        }
    }
}