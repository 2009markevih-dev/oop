using System;


public class Money
{
    public decimal Amount { get; set; } // сума грошей

    public Money(decimal amount)
    {
        Amount = amount;
    }

    
    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount);
    }

  
    public static Money operator -(Money a, Money b)
    {
        return new Money(a.Amount - b.Amount);
    }
}

class Program
{
    static void Main()
    {
        Money m1 = new Money(100);
        Money m2 = new Money(30);

        Money sum = m1 + m2;  
        Money diff = m1 - m2; 

        Console.WriteLine("Перша сума: " + m1.Amount);
        Console.WriteLine("Друга сума: " + m2.Amount);
        Console.WriteLine("Додавання: " + sum.Amount);
        Console.WriteLine("Віднімання: " + diff.Amount);
    }
}
