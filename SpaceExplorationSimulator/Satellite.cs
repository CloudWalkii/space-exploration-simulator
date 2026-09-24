using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    class Satellite : SpaceCraft
    {
        private int ScanRange;

        public int range
        {
            get => ScanRange;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Range cannot be Negative");
                ScanRange = value;
            }
        }
        public Satellite(string n , double f , int s , int scan) : base(n,f,s)
        {
            range = scan;
        }
        public override void PerformMission()
        {
            Console.WriteLine($"Satellite {name} is Performing it's mission" +
                $"\nOrbiting around the planet with {speed} KM/H" +
                $"\nRemaining Fuel Level : {Fuel}");
        }
    }
}
