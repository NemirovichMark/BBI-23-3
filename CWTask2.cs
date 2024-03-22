using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    abstract class Disciple
    {
        protected string Name;
        protected int Age;
        protected int[] Grades;
        protected double AverageGrade;

        protected Disciple(string name, int age, int[] grades)
        {
            Name = name;
            Age = age;
            Grades = grades;
            AverageGrade = Grades.Average();
        }

        public abstract void PrintInfo();

        public double GetAverageGrade()
        {
            return AverageGrade;
        }
    }

    class Pupil : Disciple
    {
        protected string Grade;
        protected string Specialization;

        public Pupil(string name, int age, int[] grades, string grade, string specialization)
            : base(name, age, grades)
        {
            Grade = grade;
            Specialization = specialization;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Оценки: {Grade}");
            Console.WriteLine($"Специализация: {Specialization}");
            Console.WriteLine($"Средний балл: {GetAverageGrade()}");
            Console.WriteLine("");
        }
    }

    class Student : Disciple
    {
        protected string Group;
        protected bool IsDebtor;
        protected string StudentID;

        public Student(string name, int age, int[] grades, string group, string studentID)
            : base(name, age, grades)
        {
            Group = group;
            IsDebtor = Grades.Contains(2);
            StudentID = studentID;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Группа: {Group}");
            Console.WriteLine($"СтудБилет: {StudentID}");
            Console.WriteLine($"Средний балл: {GetAverageGrade()}");
            Console.WriteLine($"Должник: {IsDebtor}");
            Console.WriteLine("");
        }
    }

    class Program
    {
        static void Main()
        {
            Pupil[] pupils = new Pupil[]
            {
            new Pupil("Алиса", 16, new int[] {5, 4, 4, 5, 5}, "11", "Математика"),
            new Pupil("Владимир", 15, new int[] {4, 3, 5, 4, 4}, "10", "Биология"),
            new Pupil("Елизавета", 17, new int[] {5, 4, 5, 5, 5}, "12", "История")
            };

            Student[] students = new Student[]
            {
            new Student("Давид", 20, new int[] {4, 3, 2, 4, 4}, "ББИ-23-3", "m2307490"),
            new Student("Ева", 19, new int[] {5, 5, 4, 5, 4}, "ББИ-23-1", "m1234567")
            };

            List<Disciple> allDisciples = new List<Disciple>();
            allDisciples.AddRange(pupils);
            allDisciples.AddRange(students);

            Console.WriteLine("Ученики:");
            foreach (Pupil pupil in pupils.OrderByDescending(x => x.GetAverageGrade()))
            {
                pupil.PrintInfo();
            }

            Console.WriteLine("\nСтуденты:");
            foreach (Student student in students.OrderByDescending(x => x.GetAverageGrade()))
            {
                student.PrintInfo();
            }

            Console.WriteLine("\nКраснодипломники:");
            foreach (var disciple in allDisciples.Where(d => d.GetAverageGrade() > 4.5))
            {
                disciple.PrintInfo();
            }
        }
    }


}
