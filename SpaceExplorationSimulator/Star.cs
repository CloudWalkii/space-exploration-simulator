using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    class Star : SpaceObject
    {
        private int Temprature { set; get; }

        public Star(int temp , string n , double m , Coordinates c) : base( n ,m ,c)
        {
            Temprature = temp;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"{name} Star has a Temprature of {Temprature} Celsius\nMass : {mass} KG");
            PrintCoordinates();
        }
    }
}
