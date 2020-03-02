using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;

        public SweepstakesQueueManager()
        {

        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            string sweepstakesStr = "sweepstakes";
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesStr);
            return sweepstakes;
        }
    }
}
