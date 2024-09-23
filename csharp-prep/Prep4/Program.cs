using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        string userInput = " ";
        int sum = 0;
        int min = 100000000;
        int max = -10000000;
        int smallestPositive = 1000000000;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int exitNumber = -1;

        while (exitNumber != 0)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            exitNumber = int.Parse(userInput);
            
            if (exitNumber != 0)
            {
                numbers.Add(exitNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum = sum + number;

            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }

            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }

        }

        int div = numbers.Count;
        double average = 0;

        if (div != 0)
        {
            average = (double)sum / div;
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The smallest number is {min}");
        Console.WriteLine($"The smallest positive number is {smallestPositive}");

        numbers.Sort();

        Console.WriteLine("The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}