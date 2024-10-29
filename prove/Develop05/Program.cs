using System;

//I added a function to make the user hold their breath for 15 seconds if the activity time is longer than 60 seconds, breathing activity.


class Program
{
    static void Main(string[] args)
    {
        string choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities Program!");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectionActivity = new ReflectingActivity();
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return; 
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        } while (choice != "4"); 
    }
}
