using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesSolid._Interfaces
{
    public interface IVehicle
    {
        int Wheels { get; }
        int Doors { get;  }
        int PassengerCapacity { get; }
        double EngineVolume { get; }

        void Start();
        void Stop();
        
    }
}
