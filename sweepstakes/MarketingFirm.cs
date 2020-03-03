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
        Contestant winner;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepstake()
        {
            sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor(UserInterface.contestNamePrompt));
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
            CreateSweepstake();
            manager.InsertSweepstakes(sweepstakes);
            CreateContestants();
            winner = sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(winner);
        }
    }
}
