using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Simulation
    {
        ISweepstakesManager manager;
        public void CreateMarketingFirmWithManager()
        {
            if (true)
            {
                manager = new SweepstakesStackManager();
            }
            else
            {
                manager = new SweepstakesQueueManager();
            }
            
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
