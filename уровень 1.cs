struct Participant
{
    private string _surname;
    private string _group;
    private string _teacherSurname;
    private int _result;
    private string _normative;

    public int Result => _result; // read-only property
    public string Normative => _normative; // read-only property
    public Participant(string surname, string group, string teacherSurname , int result)
    {
        _surname = surname;
        _group = group;
        _teacherSurname = teacherSurname;
        _result = result;
        if (result >= 500)
        {
            _normative = "Сдала";
        }
        else
        {
            _normative = "Не сдала";
        }

    }

    public void Print()
    {
        Console.WriteLine( _surname + "     " + _group + "          " + _teacherSurname + "          " + _result + "         " + _normative);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Participant[] participants = new Participant[5]
        {
            new Participant("Sudakov", "A", "Smit",432),
            new Participant("Leontev", "B", "Kozlov",501),
            new Participant("Kirilov", "A", "Smit",499),
            new Participant("Kotikov", "B", "Kozlov",514),
            new Participant("Frolov", "B", "Kozlov",389)
        };

        Sort(participants);
        Console.WriteLine("Результирующая таблица:");
        Console.WriteLine("Фамилия\t Группа\t Преподаватель\t Результат\t Выполнение норматива");
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
                if (Participants[j].Result < Participants[j-1].Result)
                {
                    Participant temp = Participants[j];
                    Participants[j] = Participants[j - 1];
                    Participants[j - 1] = temp;
                }



            }
        }
        int c = 0;
        for (int i = 1; i < Participants.Length; i++)
        {
           
            if (Participants[i].Normative == "Сдала")
            {
                c++;
            }
            
        }
        Console.WriteLine($"Суммарное количество участниц, выполнивших норматив: {c}");

    }
}