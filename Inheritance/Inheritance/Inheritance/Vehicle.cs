using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract public class Vehicle : IAutomobile
    {
        public string LicensePlate
        { get; protected set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; } 
        
        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public virtual void Honk()
        {
            Console.WriteLine("HONK!");
        }
        public abstract string Describe();
    }
}
