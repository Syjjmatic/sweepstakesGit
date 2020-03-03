using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;

        public string Name { get; }

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {            
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            int winningNumber;
            Contestant winningContestant;

            winningNumber = UserInterface.random.Next(1, contestants.Count);
            winningContestant = contestants[winningNumber];
            return winningContestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Name: " + contestant.lastName + ", " + contestant.firstName + "\n" +
                "Email: " + contestant.emailAddress + "\n" +
                "Registration Number: " + contestant.registrationNumber);
        }

        public void NotifyContestants(Contestant winner)
        {
            foreach (Contestant contestant in contestants.Values)
            {
                if (contestant == winner)
                {
                    Console.WriteLine("You win, lol.");
                }
                else
                {
                    Console.WriteLine("lol, good try.");
                }

            }
        }
    }
}
