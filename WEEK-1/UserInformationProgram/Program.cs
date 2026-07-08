using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your city: ");
        string city = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("===== User Information =====");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age  : {age}");
        Console.WriteLine($"City : {city}");
    }
}