using System;

public class Money
{
    public int rubles;
    public int kopeks;

    public Money(int rubles, int kopeks)
    {
        this.rubles = rubles;
        this.kopeks = kopeks;
    }

    public void Display()
    {
        Console.WriteLine($"{rubles} рублей {kopeks} копеек");
    }
}

public class Good
{
    public string name;
    public Money price;

    public Good(string name, Money price)
    {
        this.name = name;
        this.price = price;
    }

    public void DecreasePrice(int percent)
    {
        int totalKopeks = price.rubles * 100 + price.kopeks;
        decimal percentDecimal = percent / 100.0m;
        decimal decreaseAmount = totalKopeks * percentDecimal;

        int newTotalKopeks = (int)Math.Round(totalKopeks - decreaseAmount);
        int newRubles = newTotalKopeks / 100;
        int newKopeks = newTotalKopeks % 100;

        price = new Money(newRubles, newKopeks);
    }

    public void Display()
    {
        Console.WriteLine($"Название товара: {name}");
        Console.Write("Цена: ");
        price.Display();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Money price = new Money(100, 50);
        Good good = new Good("Телефон", price);
        good.Display();

        good.DecreasePrice(15);
        good.Display();
    }
}