using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var chars = name.ToCharArray();
            Array.Reverse(chars);
            var reversedName = String.Join("", chars);
            reversedName = reversedName.Substring(0, 1).ToUpper() + reversedName.Substring(1).ToLower();
            Console.WriteLine($"That's a nice name, but I'm going to call you {reversedName}.");
            Console.WriteLine($"What's up {reversedName}?!?");
        }
    }
}
