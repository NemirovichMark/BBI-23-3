using System;
using System.Collections.Generic;
using System.Linq;

class GroupResult
{
    public int SumOfGradePoints { get; private set; }

    public string GroupName { get; private set; }

    // Конструктор класса GroupResult с двумя аргументами
    public GroupResult(string groupName, int sumOfGradePoints)
    {
        GroupName = groupName;
        SumOfGradePoints = sumOfGradePoints;
    }
}

class SessionResults
{

    public List<GroupResult> Results { get; private set; }


    public SessionResults()
    {
        Results = new List<GroupResult>();
    }

    // Метод для добавления результатов группы
    public void AddGroupResults(GroupResult result)
    {
        Results.Add(result);
    }

    // Метод для расчета среднего балла группы
    public double GetAverageForGroup(GroupResult gr)
    {
        return (double)gr.SumOfGradePoints / 5;
    }

    // Метод для печати результатов сессии
    public void PrintResults()
    {
        Console.WriteLine("{0,-15}{1,-10}", "Название группы", "Средний балл");


        foreach (var gr in Results.OrderByDescending(g => GetAverageForGroup(g)))
        {
            Console.WriteLine("{0,-15}{1,-10:F2}", gr.GroupName, GetAverageForGroup(gr));
        }
    }
}

class Program
{
    static void Main()
    {

        SessionResults sessionResults = new SessionResults();

        // Добавляем группы в объект sessionResults
        sessionResults.AddGroupResults(new GroupResult("Группа 1", 867));
        sessionResults.AddGroupResults(new GroupResult("Группа 2", 909));
        sessionResults.AddGroupResults(new GroupResult("Группа 3", 812));


        sessionResults.PrintResults();

        Console.ReadLine();
    }
}
