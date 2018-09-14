using System;
using System.Collections.Generic;
using VehiclesSolid.Land;
using VehiclesSolid.Sea;

namespace VehiclesSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> LandVehicles = new List<IVehicle>
            {
                new Motorcycle(),
                new Batmobile()
            };
            foreach (IVehicle type in LandVehicles)
            {
                type.Drive();
            }

            List<IVehicle> SeaVehicles = new List<IVehicle>
            {
                new JetSki(),
                new Houseboat()
            };
            foreach (IVehicle type in SeaVehicles)
            {
                type.Drive();
            }

            Console.ReadLine();
        }
    }
}
