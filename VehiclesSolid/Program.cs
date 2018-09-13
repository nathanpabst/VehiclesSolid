using System;
using System.Collections.Generic;
using VehiclesSolid.Sea;

namespace VehiclesSolid
{
    class Program
    {
        static void Main(string[] args)
        {


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
