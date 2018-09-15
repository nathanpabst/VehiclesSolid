using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid._Interfaces
{
    public interface AirBased : IVehicle
    {
        bool Winged { get; }
        double MaxAirSpeed { get; }
        void Fly();
    }
}
