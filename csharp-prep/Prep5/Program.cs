using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");

        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        string favoriteNumber = Console.ReadLine();
        int number = int.Parse(favoriteNumber);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        
        return square;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }

}
