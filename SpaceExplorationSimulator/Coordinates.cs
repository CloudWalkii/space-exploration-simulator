using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    public class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coordinates() : this(0, 0, 0) { }

        public Coordinates(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void DisplayCoordinates()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }
    }
}
