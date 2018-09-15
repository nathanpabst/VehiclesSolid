using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid._Interfaces
{
    public interface LandBased : IVehicle
    {
        double MaxLandSpeed {get;}
        void Drive();
    }
}
