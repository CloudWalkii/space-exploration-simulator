using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MissionManager manager = new MissionManager();

            Console.WriteLine("---- INITIALIZING CELESTIAL OBJECTS ----");
            manager.AddSpaceObject(new Planet(true, 8000000000m, "Earth", 5.97e24, new Coordinates(45.78, 568.99, 95.46)));
            manager.AddSpaceObject(new Moon("Earth", "The Moon", 7.3e22, new Coordinates(384400.3466, 6467.579, 2354.967)));
            manager.AddSpaceObject(new Star(5778, "Sun", 1.98e30, new Coordinates(457.358, 436.5679, 234.65437)));

            Console.WriteLine("\n---- INITIALIZING FLEET ----");
            manager.AddSpacecraft(new Rover("Perseverance", 85.0, 15, Terrain.Soil | Terrain.Dirt));
            manager.AddSpacecraft(new Satellite("JamesWebb", 5.0, 28000, 1500000)); 

            manager.DisplayAllObjects();

            manager.LaunchFleet();
            manager.ExecuteAllMissions();
        }
    }
}
