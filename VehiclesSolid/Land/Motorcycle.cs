using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid.Land
{
    class Motorcycle : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "automatic";
        public double EngineVolume { get; set; } = 150;
        public double MaxWaterSpeed { get; set; } = 0;
        public double MaxLandSpeed { get; set; } = 130;
        public double MaxAirSpeed { get; set; } = 0;

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine("The Scout Bobber motor bike glided over the planes with the precision of an impotent sugar glider.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
