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
            ISweepstakesManager manager;

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
