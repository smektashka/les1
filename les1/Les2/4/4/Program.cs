using System;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    ~Person()
    {
        Name = String.Empty;
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter the name of person " + (i + 1) + ": ");
            string name = Console.ReadLine();
            people[i] = new Person(name);
        }

        Console.WriteLine("\nPeople:");
        foreach (Person person in people)
        {
            Console.WriteLine(person.ToString());
        }
    }
}