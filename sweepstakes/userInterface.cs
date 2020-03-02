using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    static class UserInterface
    {
        public static string contestantFirstNamePrompt = "Enter the contestant's first name:";
        public static string contestantLastNamePrompt = "Enter the contestant's last name: ";
        public static string contestantEmailPrompt = "Enter the contestant's email address: ";
        public static string contestNamePrompt = "Enter the name of the contest: ";
        public static string queueOrStackPrompt = "Queue or stack the sweepstakes?";
        public static string incorrectInput = "Incorrect input.";
        public static Random random = new Random();

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int GetRegNum(string input)
        {
            bool userInputIsAnInteger = default;
            int regNumber = default;

            while (!userInputIsAnInteger || regNumber < 0)
            {
                userInputIsAnInteger = Int32.TryParse(input, out regNumber);
            }

            return regNumber;
        }
    }
}
