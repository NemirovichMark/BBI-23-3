using System;
using System.Net.Http.Headers;
using System.Security.Policy;

namespace Lab_6th
{
    struct Animal
    {
        private string _name; // string.Empty
        private int _age; // 0
        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void Print()
        {
            Console.WriteLine(_name + ": " + _age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("Cat", 5);
          //  cat.Print();

            Animal[] animals = new Animal[3];
            animals[0] = new Animal("Cat", 5);
            animals[1] = new Animal("Dog", 2);
            animals[2] = new Animal("Horse", 3);

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Print();
            }
        }
    }
}
