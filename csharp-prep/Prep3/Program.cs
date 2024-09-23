using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        string answer = "yes";

        while ( answer == "yes")
        {

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess = 0;
            int times = 1;
        
            do 
            {
                Console.Write("What is your guess: ");
                string guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                
                }
                else if (guess < number)
                  {
                    Console.WriteLine("Higher");
                    }
                else
                { 
                    Console.WriteLine($"You guessed it! and you did it in {times} attempts");
                    Console.Write("Play again? yes, no: ");
                    answer = Console.ReadLine();
                }
                
                times ++;
                
            }while(guess != number );
        }
    }
}