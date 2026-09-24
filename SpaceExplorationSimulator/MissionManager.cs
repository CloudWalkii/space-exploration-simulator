using System;
using System.Collections.Generic;
using SpaceExplorationSimulator;

public class MissionManager
{
    private List<SpaceObject> spaceObjects = new List<SpaceObject>();
    private List<SpaceCraft> fleet = new List<SpaceCraft>();

    public void AddSpaceObject(SpaceObject obj)
    {
        spaceObjects.Add(obj);
        Console.WriteLine($"Added {obj.name} to celestial registry.");
    }

    public void AddSpacecraft(SpaceCraft craft)
    {
        fleet.Add(craft);
        Console.WriteLine($"Added {craft.name} to fleet.");
    }

    public void DisplayAllObjects()
    {
        Console.WriteLine("\n---- REGISTERED CELESTIAL BODIES ----");
        if (spaceObjects.Count == 0)
        {
            Console.WriteLine("No space objects registered yet.");
            return;
        }

        foreach (var obj in spaceObjects)
        {
            obj.DisplayDetails(); 
            Console.WriteLine("-----------------------------------");
        }
    }

    public void LaunchFleet()
    {
        Console.WriteLine("\n---- FLEET LAUNCH SEQUENCE ----");
        foreach (var craft in fleet)
        {
            Console.Write($"[{craft.name}]: ");
            craft.Launch();
        }
    }

    public void ExecuteAllMissions()
    {
        Console.WriteLine("\n---- EXECUTING FLEET MISSIONS ----");
        foreach (var craft in fleet)
        {
            if (craft.IsLaunched)
            {
                craft.PerformMission(); 
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine($"[SKIPPED] {craft.name} cannot perform mission because it is not launched.");
            }
        }
    }
}