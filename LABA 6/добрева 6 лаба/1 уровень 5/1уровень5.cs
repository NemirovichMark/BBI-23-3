using System;
struct Student
{
    private string name;
    private int score;
    private int missedClasses;

    public string Name => name;
    public int Score => score;
    public int MissedClasses => missedClasses;

    public Student(string name, int score, int missedClasses)
    {
        this.name = name;
        this.score = score;
        this.missedClasses = missedClasses;
    }

    public void Print()
    {
        Console.WriteLine($"{Name} - {MissedClasses} пропущенных занятий");
    }

}
class Program
{
    static void Main()
    {
        Student[] students = new Student[6];
        students[0] = new Student("Илья", 2, 5);
        students[1] = new Student("Маша", 4, 3);
        students[2] = new Student("Саша", 2, 2);
        students[3] = new Student("Витя", 3, 1);
        students[4] = new Student("Соня", 5, 0);
        students[5] = new Student("Катя", 2, 4);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j].MissedClasses < students[j + 1].MissedClasses)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
        foreach (var student in students)
        {
            if (student.Score == 2)
            {
                student.Print();
            }
        }
    }
}
