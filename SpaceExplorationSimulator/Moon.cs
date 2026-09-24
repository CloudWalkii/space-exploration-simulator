using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    class Moon : SpaceObject
    {
        private string HostPlanetName;

        public string HostName
        {
            get => HostPlanetName;
            set
            {
                if ( string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty");

               HostPlanetName = value;
            }
        }
        public Moon(string host , string n , double m , Coordinates c) : base(n ,m ,c)
        {
            HostName = host;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"{name} moon is orbiting around {HostName}\nMass : {mass} KG");
            PrintCoordinates();
        }
    }
}
