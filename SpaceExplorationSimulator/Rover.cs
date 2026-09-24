using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    [Flags]
    enum Terrain
    {
        Soil = 1,
        Dirt = 2,
        Lava = 4,
        Concrete = 8,
        Diamonds = 16 ,
        Water = 32
    }
    class Rover : SpaceCraft
    {
        private Terrain TerrainType { set; get; }

        public Rover(string n , double f , int s , Terrain T) : base(n,f,s)
        {
            TerrainType = T;
        }
        public override void PerformMission()
        {
            Console.WriteLine($"Rover {name} is performing his mission" +
                $"\nArrived after traveling with {speed} KM/H" +
                $"\nLanded Safely and stepped on {TerrainType} Marking his first steps\n" +
                $"Remaining Fuel Level : {Fuel}");
        }
    }
}
