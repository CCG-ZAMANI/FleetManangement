using FleetManangement.Models;

namespace FleetManangement.Interfaces
{
    public interface IVehicleTripsInterface

    {
        public IEnumerable <VehicleTrips> GetVehicleTrips();
        
        public VehicleTrips CreateTrips(VehicleTrips VehicleTrips);
    }
}
