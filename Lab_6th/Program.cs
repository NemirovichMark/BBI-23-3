namespace Lab_6th
{
    struct Animal
    {
        private string _name; // string.Empty
        private int _age; // 0
        public string Name => _name; // read-only property
        public int Age => _age; // read-only property
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

            // Animal[] animals = new Animals[0]; // null

            Animal cat = new Animal("Cat", 5);
            //  cat.Print();
            Animal[] animals = new Animal[3];
            animals[2] = new Animal("Cat", 5);
            animals[1] = new Animal("Dog", 2);
            animals[0] = new Animal("Horse", 3);
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Print();
            }

            Sort(animals);
            Console.WriteLine("Sort ...");

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Print();
            }
            Animal[] chimeras = new Animal[0]; // null
            Animal eldest = new Animal();
            Animal youngest = new Animal();

            youngest = FindYoungest(chimeras);
            youngest.Print();

            youngest = FindYoungest(animals);
            youngest.Print();

            FindYoungestAndEldest(animals, ref youngest, ref eldest);

            youngest.Print();
            eldest.Print();


        }
        static void Sort(Animal[] animals)
        {
            for (int i = 1; i < animals.Length; i++)
            {
                Animal temp = animals[i];
                int j;
                // CompareTo - method that compare 1st string and 2nd string
                // if 1st > 2nd than temp.Name.CompareTo(animals[i-1].Name) 1
                // if 1st = 2nd than temp.Name.CompareTo(animals[i-1].Name) 0
                // if 1st < 2nd than temp.Name.CompareTo(animals[i-1].Name) -1
                for (j = i; j > 0 && temp.Name.CompareTo(animals[j - 1].Name) < 0; j--)
                {
                    animals[j] = animals[j - 1];
                }
                animals[j] = temp;
            }
        }

        static Animal FindYoungest(Animal[] animals)
        {
            if (animals == null || animals.Length == 0)
                return new Animal();

            Animal youngest = animals[0];
            for (int i = 1; i < animals.Length; i++)
            {
                if (youngest.Age > animals[i].Age)
                {
                    youngest = animals[i];
                }
            }

            return youngest;
        }
        static void FindYoungestAndEldest(Animal[] animals, ref Animal youngest, ref Animal eldest)
        {
            if (animals == null || animals.Length == 0)
                return;

            youngest = animals[0];
            eldest = animals[0];
            for (int i = 1; i < animals.Length; i++)
            {
                if (youngest.Age > animals[i].Age)
                {
                    youngest = animals[i];
                }
                if (eldest.Age < animals[i].Age)
                {
                    eldest = animals[i];
                }
            }
        }
    }
}
