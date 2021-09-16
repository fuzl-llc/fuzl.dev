using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        Console.WriteLine($"Hi {name}!");
    }
}
