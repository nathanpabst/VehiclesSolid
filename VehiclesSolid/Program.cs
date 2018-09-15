﻿using System;
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

            

            var seavehicles = new List<SeaBased> { jetski, houseboat };
            
            foreach (var type in seavehicles)
            {
                type.Drive();
            }

            Console.ReadLine();
        }
    }
}
