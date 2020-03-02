using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    static class UserInterface
    {
        public static string firstNamePrompt = "Enter the contestant's first name:";
        public static string lastNamePrompt = "Enter the contestant's last name: ";
        public static string emailPrompt = "Enter the contestant's email address: ";
        public static string regNumPrompt = "Enter the contestant's registration number: ";

        public static string GetUserInputFor(string prompt)
        {
            return Console.ReadLine();
        }

        public static int CheckIfInt(string input)
        {
            bool userInputIsAnInteger = default;
            int regNumber = default;

            while (!userInputIsAnInteger || regNumber < 0)
            {
                userInputIsAnInteger = Int32.TryParse(UserInterface.GetUserInputFor(UserInterface.regNumPrompt), out regNumber);
            }

            return regNumber;
        }
    }
}
