using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid._Interfaces
{
    public interface SeaBased : IVehicle
    {
        double MaxWaterSpeed { get; }
        void Drive();
    }
}
