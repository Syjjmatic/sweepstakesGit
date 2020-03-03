using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Simulation
    {
        MarketingFirm marketingFirm;

        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = default;
            string userInput;
            bool isStackOrQueue = default;
            
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
            
            marketingFirm = new MarketingFirm(manager);
        }

        public void RunSimulation()
        {
            //CreateMarketingFirmWithManager();
            //marketingFirm.RunMarketingFirm();            
        }
    }
}
