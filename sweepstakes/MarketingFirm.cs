using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        Sweepstakes sweepstakes;        

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepstake()
        {
            sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor(UserInterface.contestNamePrompt));
            manager.InsertSweepstakes(sweepstakes);
        }

        public void CreateContestants()
        {
            int amountOfContestantsAdded;

            amountOfContestantsAdded = UserInterface.GetInteger(UserInterface.GetUserInputFor(UserInterface.howManyContestants));
            for (int i = 0; i < amountOfContestantsAdded; i++)
            {
                Contestant contestant = new Contestant();
                sweepstakes.RegisterContestant(contestant);
            }
        }

        public void RunMarketingFirm() // this show that code works
        {
            //CreateSweepstake();
            //CreateContestants();
            //Contestant winner = sweepstakes.PickWinner();            
            //sweepstakes.PrintContestantInfo(winner);
            //sweepstakes.NotifyContestants(winner);
        }
    }
}
