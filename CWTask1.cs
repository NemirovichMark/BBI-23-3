using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_1
{
    using System;

    struct Disciple
    {
        private string Name;
        private int Age;
        private int[] Grades;
        private double AverageGrade;
        private bool Krasn;

        private Disciple(string name, int age, int[] grades)
        {
            Name = name;
            Age = age;
            Grades = grades;
            AverageGrade = grades.Average();
            Krasn = AverageGrade > 4.5;
        }

        private void PrintAllDisciples(Disciple[] disciples)
        {
            foreach (var disciple in disciples)
            {
                Console.WriteLine($"Имя: {disciple.Name}");
                Console.WriteLine($"Возраст: {disciple.Age}");
                Console.WriteLine("Оценки: " + string.Join(", ", disciple.Grades));
                Console.WriteLine("Средний балл: " + disciple.AverageGrade);
                if (disciple.Krasn)
                {
                    Console.WriteLine("Статус: Краснодипломник\n");
                }
                else
                {
                    Console.WriteLine("Статус: Не краснодипломник\n");
                }
            }
        }

        private bool IsKrasn()
        {
            return Krasn;
        }

        static void Main()
        {
            Disciple[] students = new Disciple[]
            {
            new Disciple("Валерия", 18, new int[] {5, 5, 4, 4, 5}),
            new Disciple("Дмитрий", 17, new int[] {4, 3, 5, 4, 4}),
            new Disciple("Кристина", 16, new int[] {5, 4, 5, 5, 5}),
            new Disciple("Светлана", 19, new int[] {3, 4, 3, 4, 4}),
            new Disciple("Александр", 17, new int[] {5, 5, 5, 4, 5})
            };

            Array.Sort(students, (x, y) => String.Compare(x.Name, y.Name));

            Console.WriteLine("Информация об учащемся:");
            students[0].PrintAllDisciples(students);
        }
    }

}
