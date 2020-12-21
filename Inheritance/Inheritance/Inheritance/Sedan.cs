using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Sedan : Vehicle
    {

    

        public Sedan(double speed) : base(speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }

        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate \"{LicensePlate}\".";
        }

    }
}