using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Truck : Vehicle
    {
       

        public Truck(double speed, double weight) : base(speed)
        {
            Speed = speed;

            LicensePlate = Tools.GenerateLicensePlate();
            

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate \"{LicensePlate}\".";
        }

    }
}
