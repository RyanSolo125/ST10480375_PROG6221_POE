using System;

class Program
{
    static void Main()
    {
        // set console title
        Console.Title = "CCP Cyber Crime Protection";

        // play intro sound and show logo
        UIHelper.PlayVoice();
        UIHelper.ShowAscii();

        // display heading
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("========================================");
        Console.WriteLine("   CCP CYBER CRIME PROTECTION SYSTEM   ");
        Console.WriteLine("========================================");
        Console.ResetColor();
        Console.WriteLine();

        // ask user for name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        // if no name entered, use default
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "User";
        }

        // welcome message
        Console.WriteLine($"\nHello {name}!");
        Console.WriteLine("Type 'help' or 'exit'\n");

        // main chatbot loop
        while (true)
        {
            // user input label
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You > ");
            Console.ResetColor();

            string input = Console.ReadLine();

            // check for empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                UIHelper.TypeText("Please enter something.");
                UIHelper.ShowDivider();
                continue;
            }

            input = input.ToLower();

            // exit condition
            if (input == "exit")
            {
                UIHelper.TypeText("Goodbye!");
                break;
            }

            // send input to chatbot
            Chatbot.Respond(input);

            // show divider after response
            UIHelper.ShowDivider();
        }
    }
}