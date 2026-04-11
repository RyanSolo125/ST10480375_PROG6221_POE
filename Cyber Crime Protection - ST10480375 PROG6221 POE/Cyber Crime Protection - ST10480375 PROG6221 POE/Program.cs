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


        // headding
        Console.WriteLine("========================================");
        Console.WriteLine(" Welcome to CCP Cyber Crime Protection ");
        Console.WriteLine("========================================\n");


        // enter name
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

            // output for unknown input 
            if (string.IsNullOrWhiteSpace(input))
            {
                TypeText("I didn't quite understand that. Could you rephrase?");
                continue;
            }


            // exit program
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
            TypeText("I'm working perfectly and ready to help you understand the dangers of cyber crime!");
        }

        else if (input.Contains("purpose"))
        {
            TypeText("My purpose is to help you understand cybersecurity and stay safe online.");
        }

        else if (input.Contains("password"))
        {
            TypeText("Use strong passwords with letters, numbers, and symbols to ensure that your password cannot be guesse.");
            TypeText("Never share your password with anyone, even if you have known them for a long time.");
        }

        else if (input.Contains("phishing"))
        {
            TypeText("Phishing is when attackers trick you into giving personal information.");
            TypeText("They use fake emails or websites that look real to fool you into entering your login details or personal information.");
        }

        else if (input.Contains("virus"))
        {
            TypeText("A virus is a harmful program that spreads through your device and corrupts files or restricts functions.");
        }

        else if (input.Contains("worm"))
        {
            TypeText("A worm is a type of malware that spreads automatically across networks without user action.");
        }

        else if (input.Contains("macro"))
        {
            TypeText("Macro viruses are hidden in documents like Word or Excel files.");
            TypeText("They run when the file is opened and download other malware.");
        }

        else if (input.Contains("malware"))
        {
            TypeText("Malware is any harmful software designed to damage or steal data.");
        }

        else if (input.Contains("spyware"))
        {
            TypeText("Spyware secretly collects your personal information. An example of a type of spyware is a key-logger.");
        }

        else if (input.Contains("ransomware"))
        {
            TypeText("Ransomware is a malware that locks your files and requires you to pay real money to an attacker to unlock them.");
        }

        else if (input.Contains("safe browsing"))
        {
            TypeText("Only visit trusted websites and look for HTTPS. Ensure that your connection to a website is secure and use a VPN if possible.");
        }

        else if (input.Contains("2fa") || input.Contains("two factor"))
        {
            TypeText("Two-factor authentication adds extra security to your account by adding more steps to the login process.");
        }

        else if (input.Contains("firewall"))
        {
            TypeText("A firewall blocks unauthorized access to your system.");
        }

        else if (input.Contains("antivirus"))
        {
            TypeText("Antivirus software protects your device from threats.");
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