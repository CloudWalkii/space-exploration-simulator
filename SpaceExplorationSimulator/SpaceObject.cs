using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    public abstract class SpaceObject
    {
        private string Name;
        private double Mass;
        protected Coordinates coordinate { set; get; }

        public string name
        {
            get => Name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty");

                Name = value;
            }
        }
        protected double mass
        {
            get => Mass;
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("Mass cannot be Negative");

                Mass = value;
            }
        }

        protected SpaceObject(string n , double m , Coordinates c )
        {
            name = n;
            mass = m;
            coordinate = c  ?? new Coordinates();
        }
        protected void PrintCoordinates()
        {
            Console.Write("Coordinates -> ");
            coordinate.DisplayCoordinates();
        }
        public abstract void DisplayDetails();
    }
}
