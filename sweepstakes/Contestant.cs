﻿using System;
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

        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor(UserInterface.firstNamePrompt);
            lastName =  UserInterface.GetUserInputFor(UserInterface.lastNamePrompt);
            emailAddress = UserInterface.GetUserInputFor(UserInterface.emailPrompt);
            registrationNumber = UserInterface.GetRegNum(UserInterface.GetUserInputFor(UserInterface.regNumPrompt));
        }
    }
}
