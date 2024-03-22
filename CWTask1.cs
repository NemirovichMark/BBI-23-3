using System;

using System;

struct Contact
{
    public int Id { get; set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }

    public Contact(int id, string name, string surname, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var contacts = new Contact[5];
        contacts[0] = new Contact(0, "Красно", "Черный", "12345", "[red@mail.com](red@mail.com)");
        contacts[1] = new Contact(1, "Сине", "Белый", "67890", "[blue.mail.com](blue@mail.com)");
        contacts[2] = new Contact(2, "Зелено", "Желтый", "45678", "[green@mail.com](green@mail.com)");
        contacts[3] = new Contact(3, "Голубо", "Фиолетовый", "78901", "[lightblue@mail.com](lightblue@mail.com)");
        contacts[4] = new Contact(4, "Коричнево", "Розовый", "34567", "brown@mail.com](brown@mail.com)");


        for (int i = 0; i < contacts.Length - 1; i++)
        {
            for (int j = 0; j < contacts.Length - i - 1; j++)
            {
                if (String.CompareOrdinal(contacts[j].Surname, contacts[j + 1].Surname) > 0 ||
                    (String.CompareOrdinal(contacts[j].Surname, contacts[j + 1].Surname) == 0 &&
                     String.CompareOrdinal(contacts[j].Name, contacts[j + 1].Name) > 0))
                {
                    var temp = contacts[j + 1];
                    contacts[j + 1] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }


        Console.WriteLine("{0,-5} {1,-10} {2,-10} {3,-15} {4,-30}", "Id", "First Name", "Last Name", "Phone Number", "Email");
        Console.WriteLine(new String('-', 60));
        foreach (var contact in contacts)
        {
            Console.WriteLine("{0,-5} {1,-10} {2,-10} {3,-15} {4,-30}", contact.Id, contact.Name, contact.Surname, contact.PhoneNumber, contact.Email);
        }

        Console.ReadLine();
    }
}
