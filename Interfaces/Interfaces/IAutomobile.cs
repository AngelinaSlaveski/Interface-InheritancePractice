using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IAutomobile
    {
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
}
