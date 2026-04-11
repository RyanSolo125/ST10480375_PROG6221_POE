using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "CCP Cyber Crime Protection";

        // calling audio and art methods

        PlayVoice();

        ShowAscii();

        Console.WriteLine("========================================");
        Console.WriteLine(" Welcome to CCP Cyber Crime Protection ");
        Console.WriteLine("========================================\n");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "User";
        }

        Console.WriteLine("\nHello " + name + "! Ask me about cybersecurity.");
        Console.WriteLine("Type 'help' to see topics or 'exit' to quit.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("> ");
            Console.ResetColor();

            string input = Console.ReadLine().ToLower();

            // output for unknown inputs

            if (string.IsNullOrWhiteSpace(input))
            {
                TypeText("I didn't quite understand that. Could you rephrase?");
                continue;
            }

            if (input == "exit")
            {
                TypeText("Goodbye! Stay safe online.");
                break;
            }

            Respond(input);
        }
    }

    // voice method

    static void PlayVoice()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("welcome.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("(Voice file not found)");
        }
    }

    // art

    static void ShowAscii()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
   ██████╗ ██████╗ ██████╗
  ██╔════╝██╔════╝██╔══██╗
  ██║     ██║     ██████╔╝
  ██║     ██║     ██╔═══╝ 
  ╚██████╗╚██████╗██║     
   ╚═════╝ ╚═════╝╚═╝     

   [ CYBER CRIME PROTECTION ]

   >>> Secure Your Digital Life <<<
");

        Console.ResetColor();
    }

    static void Respond(string input)
    {

        //input prompts

        if (input.Contains("help"))
        {
            TypeText("You can ask about:");
            TypeText("- phishing");
            TypeText("- viruses / worms / macros");
            TypeText("- malware / spyware / ransomware");
            TypeText("- passwords");
            TypeText("- safe browsing");
            TypeText("- 2FA, firewall, antivirus");
        }

        // answers

        else if (input.Contains("how are you"))
        {
            TypeText("I'm working perfectly and ready to help!");
        }

        else if (input.Contains("purpose"))
        {
            TypeText("My purpose is to help you understand cybersecurity and stay safe online.");
        }

        else if (input.Contains("password"))
        {
            TypeText("Use strong passwords with letters, numbers, and symbols.");
            TypeText("Never share your password with anyone.");
        }

        else if (input.Contains("phishing"))
        {
            TypeText("Phishing is when attackers trick you into giving personal information.");
            TypeText("They use fake emails or websites that look real.");
        }

        else if (input.Contains("virus"))
        {
            TypeText("A virus is a harmful program that spreads and damages files.");
        }

        else if (input.Contains("worm"))
        {
            TypeText("A worm spreads automatically across networks without user action.");
        }

        else if (input.Contains("macro"))
        {
            TypeText("Macro viruses are hidden in documents like Word or Excel files.");
            TypeText("They run when the file is opened.");
        }

        else if (input.Contains("malware"))
        {
            TypeText("Malware is any harmful software designed to damage or steal data.");
        }

        else if (input.Contains("spyware"))
        {
            TypeText("Spyware secretly collects your personal information.");
        }

        else if (input.Contains("ransomware"))
        {
            TypeText("Ransomware locks your files and asks for money to unlock them.");
        }

        else if (input.Contains("safe browsing"))
        {
            TypeText("Only visit trusted websites and look for HTTPS.");
        }

        else if (input.Contains("2fa") || input.Contains("two factor"))
        {
            TypeText("Two-factor authentication adds extra security to your account.");
        }

        else if (input.Contains("firewall"))
        {
            TypeText("A firewall blocks unauthorized access to your system.");
        }

        else if (input.Contains("antivirus"))
        {
            TypeText("Antivirus software protects your computer from threats.");
        }

        else
        {
            TypeText("I didn't quite understand that. Type 'help' to see what you can ask.");
        }
    }

    // sleep(20) to make the text appear like the chatbot is actually talking

    static void TypeText(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }
}