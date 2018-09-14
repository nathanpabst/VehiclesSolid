using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid.Air
{
    class a10Warthog : IVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 7;
        public int PassengerCapacity { get; set; } = 13;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 89.1;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; } = 85;
        public double MaxAirSpeed { get; set; } = 400.5;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The A10 Warthog patrols the sky with the careful eye of a mall cop watching over the food court.");
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
