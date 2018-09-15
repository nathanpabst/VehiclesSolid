﻿using System;
using System.Collections.Generic;
using System.Text;
using VehiclesSolid._Interfaces;

namespace VehiclesSolid.Air
{
    class Cessna : AirBased
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; } = 31.1;
        public double MaxLandSpeed { get; set; } = 85;
        public double MaxAirSpeed { get; set; } = 309.0;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the sun");
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
