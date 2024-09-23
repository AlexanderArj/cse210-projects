using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please write your last name:");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {name} {LastName}.");

    }
}