using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal program!");
        
        int exitOption =-1;
        while (exitOption != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");

            Console.WriteLine("3. Load");

            Console.WriteLine("4. Save");

            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            
            string numberMenu = Console.ReadLine();
            
            switch (numberMenu)
            {
                case "1":

                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    string answer = Console.ReadLine();
                    
                    Entry newEntry = new Entry();

                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");

                    newEntry._promptText = prompt;

                    newEntry._entryText = answer;
                    
                    journal.AddEntry(newEntry);

                    break;

                case "2":

                    journal.DisplayAllEntries();

                    break;

                case "3":

                    Console.Write("Enter the filename to load: ");

                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);

                    break;

                case "4":

                    Console.Write("Enter the filename to save: ");

                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    break;

                case "5":

                    exitOption = 5;

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;

            }

        }

    }

}
