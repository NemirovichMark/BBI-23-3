
// 5 number 1 уровень
/*
struct Student
{
    private string _Name;
    private int _Grade;
    private int _Propuski;

    public int Grade => _Grade; // read- only property
    public int Propuski => _Propuski; // read-only property
    public Student(string Name, int Grade, int Propuski)
    {
        _Name = Name;
        _Grade = Grade;
        _Propuski = Propuski;
    }
    public void Print()
    {
        Console.WriteLine("{0,-5}|{1,-8}|{2,-3}", _Name, _Grade, _Propuski);
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[6]
        {
            new Student("Alisa", 2, 4),
            new Student("Artem", 5, 1),
            new Student("Liza", 4, 2),
            new Student("Anna", 2, 6),
            new Student("Mark", 5, 4),
            new Student("Ivan", 2, 0)

        };
        Sort(students);
        Console.WriteLine("Имя  | Оценка | Пропуски ");
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Grade == 2)
            {
                students[i].Print();
            }
        }
        Console.ReadKey();
    }
    static void Sort(Student[] Students)
    {

        for (int i = 1; i < Students.Length; i++)
        {
            for (int j = 1; j < Students.Length; j++)
            {
                if (Students[j].Propuski > Students[j - 1].Propuski)
                {
                    (Students[j], Students[j - 1]) = (Students[j - 1], Students[j]);


                }
            }
        }
    }

}

*/






// НОМЕР 6  2 уровень


/*
struct Diver
{
    private string _Surname;
    private double[,] _Ball;

    public string Surname => _Surname;

    public double TotalBall
    {
        get
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += _Ball[0, i] + _Ball[1, i];
            }
            return sum;
        }
    }
    public Diver(string surname, double[,] Ball)
    {
        _Surname = surname;
        _Ball = Ball;
    }
    public void Print()
    {
        Console.Write("{0,-10}-", Surname);
        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0}({1}), ", _Ball[0, i], _Ball[1, i]);

        }
        Console.WriteLine("Total: {0}", TotalBall);
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        double[,] ball1 = { { 8.5, 8.0, 9.0, 9.5, 8.5 }, { 7.0, 8.5, 7.5, 8.0, 6.5 } };
        double[,] ball2 = { { 7.5, 8.0, 7.5, 8.0, 7.0 }, { 6.5, 7.0, 6.0, 7.5, 6.0 } };
        double[,] ball3 = { { 6.5, 7.0, 7.0, 7.5, 6.5 }, { 8.0, 7.5, 7.0, 8.5, 7.5 } };
        double[,] ball4 = { { 7.0, 6.5, 8.0, 6.5, 8.5 }, { 8.0, 6.0, 7.5, 6.0, 7.0 } };
        double[,] ball5 = { { 8.0, 8.5, 7.5, 7.0, 8.0 }, { 6.0, 6.5, 7.0, 6.5, 7.5 } };


        Diver[] divers = new Diver[5]
        {
            new Diver("Иванов",ball1),
            new Diver("Петров",ball2),
            new Diver("Сидоров",ball3),
            new Diver("Козлов",ball4),
            new Diver("Захаров",ball5)

        };
        Sort(divers);
        Console.WriteLine("Итоговый протокол соревнований:");
        for (int i = 0; i < divers.Length; i++)
        {
            divers[i].Print();
        }
        Console.ReadKey();
    }

    static void Sort(Diver[] divers)
    {
        for (int i = 0; i < divers.Length - 1; i++)
        {
            for (int j = i + 1; j < divers.Length; j++)
            {
                if (divers[j].TotalBall > divers[i].TotalBall)
                {
                    (divers[j], divers[i]) = (divers[i], divers[j]);
                }
            }
        }
    }
}

*/




//3 уровень 3

using System;

public struct Team
{
    private int[] results;

    public Team(int[] results)
    {
        this.results = results;
    }

    public int SumPoints()
    {
        int points = 0;
        for (int i = 0; i < results.Length; i++)
        {
            if (results[i] == 1)
            {
                points += 5;
            }
            else if (results[i] == 2)
            {
                points += 4;
            }
            else if (results[i] == 3)
            {
                points += 3;
            }
            else if (results[i] == 4)
            {
                points += 2;
            }
            else if (results[i] == 5)
            {
                points += 1;
            }
            else
            {
                points += 0;
            }
        }
        return points;
    }
}

class Program
{
    static void Main()
    {
        int[] resultsTeam1 = { 1, 2, 3, 4, 5, 6 };
        int[] resultsTeam2 = { 7, 8, 9, 10, 11, 12 };
        int[] resultsTeam3 = { 13, 14, 15, 16, 17, 18 };

        Team team1 = new Team(resultsTeam1);
        Team team2 = new Team(resultsTeam2);
        Team team3 = new Team(resultsTeam3);

        int pointsTeam1 = team1.SumPoints();
        int pointsTeam2 = team2.SumPoints();
        int pointsTeam3 = team3.SumPoints();

        if (pointsTeam1 > pointsTeam2 && pointsTeam1 > pointsTeam3)
        {
            Console.WriteLine("Команда 1 победила с " + pointsTeam1 + " баллами");
        }
        else if (pointsTeam2 > pointsTeam1 && pointsTeam2 > pointsTeam3)
        {
            Console.WriteLine("Команда 2 победила с " + pointsTeam2 + " баллами");
        }
        else if (pointsTeam3 > pointsTeam1 && pointsTeam3 > pointsTeam2)
        {
            Console.WriteLine("Команда 3 победила с " + pointsTeam2 + " баллами");
        }
        else if (pointsTeam1 == pointsTeam2 && pointsTeam1 == pointsTeam3 && pointsTeam2 == pointsTeam3)
        {
            int firstPlaceTeam1 = resultsTeam1[0];
            int firstPlaceTeam2 = resultsTeam2[0];
            int firstPlaceTeam3 = resultsTeam3[0];

            if (firstPlaceTeam1 == 1)
            {
                Console.WriteLine("Команда 1 победила с " + pointsTeam1 + " баллами");
            }
            else if (firstPlaceTeam2 == 1)
            {
                Console.WriteLine("Команда 2 победила с " + pointsTeam2 + " баллами");
            }
            else if (firstPlaceTeam3 == 1)
            {
                Console.WriteLine("Команда 3 победила с " + pointsTeam3 + " баллами");
            }
        }
    }
}