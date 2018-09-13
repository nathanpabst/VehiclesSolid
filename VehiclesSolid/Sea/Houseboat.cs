using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid.Sea
{
    class Houseboat : IVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 5;
        public int PassengerCapacity { get; set; } = 15;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "V8";
        public double EngineVolume { get; set; } = 4.35;
        public double MaxWaterSpeed { get; set; } = 49;
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("The houseboat sputters over the water like a choked-out seal gasping for air.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
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
