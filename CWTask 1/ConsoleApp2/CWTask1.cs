using System;

struct SimpleDate
{
    private int _year;
    private int _month;
    private int _day;
    private string _vis;

    public SimpleDate(int year, int month, int day, string vis)
    {
        _year = year;
        _month = month;
        _day = day;
        _vis = vis;
    }

    public void visok()
    {
        string a;
        if (_year % 4 == 0)
        {
            if (_year % 100 == 0)
            {
                if (_year % 400 == 0)
                {
                    a = "Високосный";
                }
                else { a = "Не високосный"; }
            }
            else { a = "Високосный"; }
        }
        else { a = "Не високосный"; }
        _vis = a;
    }
    public void pd()
    {
        Console.WriteLine("${day}.{month}.{year}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        SimpleDate[] dates = new SimpleDate[10]
        {
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1"),
            new SimpleDate(1, 1, 1 ,"1")
        };

        for(int i = 0; i < dates.Length; i++)
        {
            if (
        }
    }
}


