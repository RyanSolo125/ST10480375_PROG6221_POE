
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
                UIHelper.TypeText("Use strong passwords with letters, numbers, and symbols to ensure that your password cannot be guessed.");
                UIHelper.TypeText("Never share your password with anyone.");
            }

            else if (input.Contains("phishing"))
            {
                UIHelper.TypeText("Phishing is when attackers trick you into giving personal information.");
                UIHelper.TypeText("They use fake emails or websites that look real.");
            }

            else if (input.Contains("virus"))
            {
                UIHelper.TypeText("A virus is a harmful program that spreads through your device and damages files.");
            }

            else if (input.Contains("worm"))
            {
                UIHelper.TypeText("A worm spreads automatically across networks without user action.");
            }

            else if (input.Contains("macro"))
            {
                UIHelper.TypeText("Macro viruses are hidden in Word or Excel files and run when opened.");
            }

            else if (input.Contains("malware"))
            {
                UIHelper.TypeText("Malware is any harmful software designed to damage or steal data.");
            }

            else if (input.Contains("spyware"))
            {
                UIHelper.TypeText("Spyware secretly collects your personal information, like a keylogger.");
            }

            else if (input.Contains("ransomware"))
            {
                UIHelper.TypeText("Ransomware locks your files and demands payment to unlock them.");
            }

            else if (input.Contains("safe browsing"))
            {
                UIHelper.TypeText("Only visit trusted websites and look for HTTPS.");
            }

            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                UIHelper.TypeText("Two-factor authentication adds extra security to your account.");
            }

            else if (input.Contains("firewall"))
            {
                UIHelper.TypeText("A firewall blocks unauthorized access to your system.");
            }

            else if (input.Contains("antivirus"))
            {
                UIHelper.TypeText("Antivirus software protects your device from threats.");
            }

            else
            {
                UIHelper.TypeText("I didn't quite understand that. Type 'help' to see options.");
            }
        }
    }
