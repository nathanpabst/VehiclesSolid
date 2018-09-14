﻿using System;
using System.Collections.Generic;
using VehiclesSolid.Air;
using VehiclesSolid.Land;
using VehiclesSolid.Sea;

namespace VehiclesSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> AirVehicles = new List<IVehicle>
            {
                new Cessna(),
                new a10Warthog()
            };
            foreach (IVehicle type in AirVehicles)
            {
                type.Fly();
            }

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
