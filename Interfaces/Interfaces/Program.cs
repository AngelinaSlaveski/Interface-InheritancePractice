using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s1 = new Sedan(60);
            Sedan s2 = new Sedan(70);
            Truck t = new Truck(45, 500);
            s1.SpeedUp();
            s2.SpeedUp();
            t.SpeedUp();

            Console.WriteLine("");
            Console.WriteLine($"Sedan with license plate \"{s1.LicensePlate}\" and {s1.Wheels} wheels, driving at {s1.Speed} km/h.");
            Console.WriteLine($"Sedan with license plate \"{s2.LicensePlate}\"and {s2.Wheels} wheels, driving at {s2.Speed} km/h.");
            Console.WriteLine($"Truck with license plate \"{t.LicensePlate}\" and {t.Wheels} wheels, driving at {t.Speed} km/h.");
            Console.WriteLine($"\n Sedan's faster speed: {s1.Speed}");
            Console.WriteLine($"Sedan's faster speed: {s2.Speed}");
            Console.WriteLine($"Truck's faster speed: {t.Speed}");



        }
    }
}
