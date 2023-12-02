using System;

public class Laptop
{
    private string name;
    private int price;
    private string processor;
    private int ram;
    private int hardDisk;

    public Laptop(string name, int price, string processor, int ram, int hardDisk)
    {
        this.name = name;
        this.price = price;
        this.processor = processor;
        this.ram = ram;
        this.hardDisk = hardDisk;
    }

    public void Display()
    {
        Console.WriteLine("Ноутбук:");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Цена: {price} P");
        Console.WriteLine($"Процессор: {processor}");
        Console.WriteLine($"Оперативная память: {ram} GB");
        Console.WriteLine($"Жесткий диск: {hardDisk} GB");
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Laptop("Lenovo", 60000, "i3", 2, 500);
        Laptop laptop2 = new Laptop("DELL", 80000, "i5", 4, 1024);
        Laptop laptop3 = new Laptop("Sony", 100000, "i9", 8, 1024);

        laptop1.Display();
        laptop2.Display();
        laptop3.Display();
    }
}