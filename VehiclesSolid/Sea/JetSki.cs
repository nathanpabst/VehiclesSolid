using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid.Sea
{
    class JetSki : IVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "automatic";
        public double EngineVolume { get; set; } = 2.1;
        public double MaxWaterSpeed { get; set; } = 50;
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            Console.WriteLine("The jetski's engine starts to grumble.");
        }

        public void Stop()
        {
            Console.WriteLine("The jetski stops.");
        }
    }
}
