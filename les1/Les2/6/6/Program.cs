using System;

public abstract class Animal
{
    public string Name { get; set; }

    public void setName(string name)
    {
        Name = name;
    }

    public string getName()
    {
        return Name;
    }

    public abstract void Eat();
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Собака ест");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the name of the dog: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        dog.setName(dogName);

        Console.WriteLine("Dog's name is: " + dog.getName());
        dog.Eat();
    }
}