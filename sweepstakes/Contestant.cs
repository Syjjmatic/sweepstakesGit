using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant(int registrationNumber)
        {
            firstName = UserInterface.GetUserInputFor(UserInterface.contestantFirstNamePrompt);
            lastName =  UserInterface.GetUserInputFor(UserInterface.contestantLastNamePrompt);
            emailAddress = UserInterface.GetUserInputFor(UserInterface.contestantEmailPrompt);
            this.registrationNumber = registrationNumber;
        }
    }
}
