using System;

class Program
{
    public static void Main(string[] args)
    {
        // Display title 
        Console.WriteLine("-----------------------------------------------------------\r");
        string Header1 = "Deliverable Two by April Carden for Oct 2021 C# After Hours\r";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Header1.Length / 2)) + "}", Header1));

        Console.WriteLine("-----------------------------------------------------------\r");
        string Header2 = "CircusBot Console App\r";
        Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Header2.Length / 2)) + "}", Header2));
        Console.WriteLine("-----------------------------------------------------------\n");

        //variables declaration        
        bool shutdown = false;
        string inputValue;
        string outputValue = "";

        //ask the user what they want to say to the bot
        Console.WriteLine("CircusBot: Hello Beautiful Human - what would you like to say to CircusBot today?\n");

        //repeat asking until bye/shutdown is true.
        while (!shutdown)
        {
            Console.Write("User: ");
            inputValue = Console.ReadLine().ToLower();//allow any casing to be used in input
            Console.Write("CircusBot: ");
            switch (inputValue)

            {
                case "hello":
                    outputValue = "Hi! Good to see you!\n";
                    break;

                case "bye":
                    outputValue = "Goodbye!\n";
                    shutdown = true; //end program
                    break;

                case "sup":
                    outputValue = "I am good!\n";
                    break;

                case "hello there":
                    outputValue = "General Kenobi\n";
                    break;

                default:
                    Console.WriteLine("I do not have a response for that.");
                    break;
            }

            Console.WriteLine(outputValue);
            //Still have to figure out printing “I’m sorry but you have already said that” if the user enters the same input twice in a row

        }
    }
}