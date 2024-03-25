class Participant
{
    private string _surname;
    private string _community;
    private int _result1;
    private int _result2;
    public int _finalresult { get; private set; }
    private bool _disqualification;
    public Participant(string surname, string community, int result1, int result2)
    {
        _surname = surname;
        _community = community;
        _result1 = result1;
        _result2 = result2;
        _finalresult = result1 + result2;
        _disqualification = false;
    }
    public void Disqualification()
    {
        if (!_disqualification)
        {
            _disqualification = true;
        }
    }
    public void Print()
    {
        if (!_disqualification)
        {
            Console.WriteLine("{0,-7} | {1,-8} | {2,-16} | {3,-2} ", _surname, _community, _result1, _result2);
        }

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
        participants[2].Disqualification();
        participants[0].Disqualification();
        for (int i = 0; i < participants.Length; i++)
        {

            participants[i].Print();
        }
        Console.ReadKey();



    }
    static void Sort(Participant[] participants)
    {
        int d = participants.Length / 2;
        while (d >= 1)
        {
            for (int i = d; i < participants.Length; i++)
            {
                int j = i;
                int x = participants[i]._finalresult;
                while (j >= d && participants[j - 1]._finalresult > x)
                {
                    Participant temp = participants[j];
                    participants[j] = participants[j - 1];
                    participants[j - 1] = temp;
                    j -= d;
                }

            }
            d /= 2;
        }
    }
}