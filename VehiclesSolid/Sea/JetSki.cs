﻿using System;
using System.Collections.Generic;
using System.Text;
using VehiclesSolid._Interfaces;

namespace VehiclesSolid.Sea
{
    public class JetSki : SeaBased
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public double EngineVolume { get; set; } = 2.1;
        public double MaxWaterSpeed { get; set; } = 50;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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
