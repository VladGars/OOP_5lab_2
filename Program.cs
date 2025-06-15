using System;

// 1. Створення інтерфейсу
public interface IDisplayable
{
    void Display();
}

// 2. Реалізація в базовому класі
public class Shape : IDisplayable
{
    public virtual void Display()
    {
        Console.WriteLine("Це загальна фігура.");
    }
}

// 3. Перевизначення в похідному класі
public class Circle : Shape
{
    public override void Display()
    {
        Console.WriteLine("Це коло.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Shape();
        Circle myCircle = new Circle();

        myShape.Display();  // Виклик реалізації базового класу
        myCircle.Display(); // Виклик перевизначеної реалізації
    }
}