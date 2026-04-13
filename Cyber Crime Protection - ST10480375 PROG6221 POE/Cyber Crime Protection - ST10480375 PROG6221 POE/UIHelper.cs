using System;
using System.Media;
using System.Threading;

class UIHelper
{
    // method to display bot text slowly
    public static void TypeText(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Bot > ");
        Console.ResetColor();

        // typing effect
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }

    // method to show divider line
    public static void ShowDivider()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("----------------------------------------");
        Console.ResetColor();
        Console.WriteLine();
    }

    // method to show ascii art
    public static void ShowAscii()
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

    // method to play welcome sound
    public static void PlayVoice()
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
}