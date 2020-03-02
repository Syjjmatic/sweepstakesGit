using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesStackManager
    {
        Stack<Sweepstakes> stack;
        public SweepstakesStackManager()
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
