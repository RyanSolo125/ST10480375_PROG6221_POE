using System;

class Chatbot
{
    public static void Respond(string input)
    {
        if (input.Contains("help"))
        {
            UIHelper.TypeText("You can ask about:");
            UIHelper.TypeText("- phishing");
            UIHelper.TypeText("- viruses / worms / macros");
            UIHelper.TypeText("- malware / spyware / ransomware");
            UIHelper.TypeText("- passwords");
            UIHelper.TypeText("- safe browsing");
            UIHelper.TypeText("- 2FA, firewall, antivirus");
        }

        else if (input.Contains("how are you"))
        {
            UIHelper.TypeText("I'm working perfectly and ready to help you understand the dangers of cyber crime!");
        }

        else if (input.Contains("purpose"))
        {
            UIHelper.TypeText("My purpose is to help you understand cybersecurity and stay safe online.");
        }

        else if (input.Contains("password"))
        {
            UIHelper.TypeText("Use strong passwords with letters, numbers, and symbols.");
            UIHelper.TypeText("Never share your password with anyone.");
        }

        else if (input.Contains("phishing"))
        {
            UIHelper.TypeText("Phishing is when attackers trick you into giving personal information.");
        }

        else if (input.Contains("virus"))
        {
            UIHelper.TypeText("A virus is a harmful program that spreads.");
        }

        else if (input.Contains("worm"))
        {
            UIHelper.TypeText("A worm spreads automatically across networks.");
        }

        else if (input.Contains("macro"))
        {
            UIHelper.TypeText("Macro viruses are hidden in Word or Excel files.");
        }

        else if (input.Contains("malware"))
        {
            UIHelper.TypeText("Malware is harmful software.");
        }

        else if (input.Contains("spyware"))
        {
            UIHelper.TypeText("Spyware collects your personal information.");
        }

        else if (input.Contains("ransomware"))
        {
            UIHelper.TypeText("Ransomware locks your files and demands payment.");
        }

        else if (input.Contains("safe browsing"))
        {
            UIHelper.TypeText("Only visit trusted websites and look for HTTPS.");
        }

        else if (input.Contains("2fa") || input.Contains("two factor"))
        {
            UIHelper.TypeText("Two-factor authentication adds extra security.");
        }

        else if (input.Contains("firewall"))
        {
            UIHelper.TypeText("A firewall blocks unauthorized access.");
        }

        else if (input.Contains("antivirus"))
        {
            UIHelper.TypeText("Antivirus protects your device.");
        }

        else
        {
            UIHelper.TypeText("I didn't understand that. Type 'help'.");
        }
    }
}