using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your grade: ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        string letter = "Letter";

        if ( gradeNumber >= 90)
        {
            letter = "A";
        }

        else if ( gradeNumber >= 80)
        {
            letter = "B";
        }

        else if ( gradeNumber >= 70)
        {
            letter = "C";
        }

        else if ( gradeNumber >= 60 )
        {
            letter = "D";
        }

        else if ( gradeNumber < 60)
        { 
            letter = "F";
        }

        int remainder = gradeNumber % 10;

        if ( remainder >= 7 && letter != "A" && letter != "F")
        {
            Console.WriteLine($"Your grade letter is {letter}+");
        }

        else if ( remainder < 3 && letter != "F")
        {
            Console.WriteLine($"Your grade letter is {letter}-");
        }

        else
        {
            Console.WriteLine($"Your grade letter is {letter}");
        }

        if ( gradeNumber >= 70)
        {
            Console.WriteLine("You pass! Congratulations!");

        }
        else
        {
            Console.WriteLine("Almost there! You did not pass the course, but surely you will do it better next time! ");
        }
        
    }
}