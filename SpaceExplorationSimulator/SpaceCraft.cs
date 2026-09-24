using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExplorationSimulator
{
    public abstract class SpaceCraft
    {
        private string Name;
        private double FuelLevel;
        private int Speed;
        public bool IsLaunched { protected set; get; }

        public string name
        {
            get => Name;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Name cannot be empty");
                Name = value;
            }
        }
        public double Fuel
        {
            get => FuelLevel;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException("Fuel Level should be between 0% and 100%");
                FuelLevel = value;
            }
        }
        public int speed
        {
            get => Speed;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("There is no Negative speed");
                Speed = value;
            }
        }
        public bool Launch()
        {
            if (IsLaunched) { Console.WriteLine("It's already Launched!!"); return true; }
            else if (Fuel < 10) { Console.WriteLine("Fuel up First!!"); return false; }
            else
            {
                Console.WriteLine("It's Launching!!!");
                IsLaunched = true;
                return true;
            }
        }
        public abstract void PerformMission();

        protected SpaceCraft(string n , double f , int s )
        {
            name = n;
            Fuel = f;
            speed = s;
            IsLaunched = false;
        }


    }
}
