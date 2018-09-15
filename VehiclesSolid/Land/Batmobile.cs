﻿using System;
using System.Collections.Generic;
using System.Text;
using VehiclesSolid._Interfaces;

namespace VehiclesSolid.Land
{
    class Batmobile : LandBased
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 2;
        public double EngineVolume { get; set; } = 290;
        public double MaxLandSpeed { get; set; } = 270;

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
            Console.WriteLine("The batmobile's tires sink into the road like a clown masterfully executing a pantomime for a crowd of blind pigeons. BAM.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}

