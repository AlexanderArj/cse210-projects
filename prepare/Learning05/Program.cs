using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment derivadas = new MathAssignment("Alexander", "Differential Calculus", "Chapters 4-5", "Problems 8-21" );

        Console.WriteLine(derivadas.GetSummary());
        Console.WriteLine(derivadas.GetHomeworkList());

        WritingAssignment history = new WritingAssignment("Carlos","European History","The causes of World War II");

        Console.WriteLine(history.GetSummary());
        Console.WriteLine(history.GetWritingInformation());

    }

}