using System;

public struct SimpleDate
{
    public int Day;
    public int Month;
    public int Year;

    public SimpleDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public bool IsLeapYear()
    {
        if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
        {
            return true;
        }
        return false;
    }

    public void PrintDate()
    {
        Console.WriteLine($"{Day:D2}.{Month:D2}.{Year:D4}");
    }
}

class Program
{
    static void Main()
    {
        SimpleDate[] dates = new SimpleDate[]
        {
            new SimpleDate(5, 12, 2023),
            new SimpleDate(10, 6, 2022),
            new SimpleDate(1, 1, 2024),
            new SimpleDate(15, 9, 2023),
            new SimpleDate(25, 11, 2021),
            new SimpleDate(8, 4, 2022),
            new SimpleDate(14, 3, 2020),
            new SimpleDate(20, 7, 2021),
            new SimpleDate(30, 5, 2022),
            new SimpleDate(11, 8, 2020)
        };

        BubbleSortDates(dates);

        Console.WriteLine("Дата       | Високосный год");
        Console.WriteLine("-------------------------");
        foreach (SimpleDate date in dates)
        {
            date.PrintDate();
            Console.WriteLine($"             | {date.IsLeapYear()}");
            Console.WriteLine("-------------------------");
        }
    }

    static void BubbleSortDates(SimpleDate[] dates)
    {
        int n = dates.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (dates[j].Year > dates[j + 1].Year ||
                    (dates[j].Year == dates[j + 1].Year && dates[j].Month > dates[j + 1].Month) ||
                    (dates[j].Year == dates[j + 1].Year && dates[j].Month == dates[j + 1].Month && dates[j].Day > dates[j + 1].Day))
                {
                    SimpleDate temp = dates[j];
                    dates[j] = dates[j + 1];
                    dates[j + 1] = temp;
                }
            }
        }
        Console.ReadKey();
    }
}

