using FleetManangement.Models;

namespace FleetManangement.Interfaces
{
    public interface IVehicleInterface
    {

        public IEnumerable<Vehicles>GetVehicles();
        public Vehicles CreateVehicle(Vehicles vehicles);

        public Vehicles UpdateVehicle(Vehicles vehicles);
    
    }
}
