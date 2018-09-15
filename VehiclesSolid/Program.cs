using System;
using System.Collections.Generic;
using VehiclesSolid._Interfaces;
using VehiclesSolid.Air;
using VehiclesSolid.Land;
using VehiclesSolid.Sea;

namespace VehiclesSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            var jetski = new JetSki();
            var houseboat = new Houseboat();
            var a10warthog = new a10Warthog();
            var cessna = new Cessna();
            var motorcycle = new Motorcycle();
            var batmobile = new Batmobile();

            var landvehicles = new List<LandBased> { motorcycle, batmobile };
            foreach (var type in landvehicles)
            {
                type.Drive();
            }

            var airvehicles = new List<AirBased> { a10warthog, cessna };
            foreach (var type in airvehicles)
            {
                type.Fly();
            }

            var seavehicles = new List<SeaBased> { jetski, houseboat };
            
            foreach (var type in seavehicles)
            {
                type.Drive();
            }

            Console.ReadLine();
        }
    }
}
