using System;
using System.Collections.Generic;
using System.Text;
using VehiclesSolid._Interfaces;

namespace VehiclesSolid.Sea
{
    public class Houseboat : SeaBased, IVehicle
    {
        public int Doors { get; set; } = 5;
        public int PassengerCapacity { get; set; } = 15;
        public int Wheels { get; set; } = 0;
        public double EngineVolume { get; set; } = 4.35;
        public double MaxWaterSpeed { get; set; } = 49;

        public void Drive()
        {
            Console.WriteLine("The houseboat sputters over the water like a choked-out seal gasping for air.");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
