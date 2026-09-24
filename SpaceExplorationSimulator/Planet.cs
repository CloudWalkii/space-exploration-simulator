using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    class Planet : SpaceObject
    {
        private bool HasAtmosphere { set; get; }
        private decimal Population;

        public decimal population
        {
            get => Population;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Population cannot be Negative");

                Population = value;
            }
        }

        public Planet(bool has, decimal pop, string n, double m, Coordinates c) : base(n, m, c)
        {
            HasAtmosphere = has;
            population = pop;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"{name} Has A Population of {population} Ihabitants" +
                $"\nMass : {mass} KG" +
                $"\nAnd a {HasAtmosphere} Condition of having an Atmosphere");
            PrintCoordinates();
        }
    }
}
