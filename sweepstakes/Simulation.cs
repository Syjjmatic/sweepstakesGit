using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Simulation
    {        
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = default;
            string userInput;
            bool isStackOrQueue = false;
            
            userInput = UserInterface.GetUserInputFor(UserInterface.queueOrStackPrompt);

            while (isStackOrQueue == false)
            {
                if (userInput.ToLower() == "stack")
                {
                    manager = new SweepstakesStackManager();
                    isStackOrQueue = true;
                }
                else if (userInput.ToLower() == "queue")
                {
                    manager = new SweepstakesQueueManager();
                    isStackOrQueue = true;
                }
                else
                {
                    Console.WriteLine(UserInterface.incorrectInput);
                }
            }          
            
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
