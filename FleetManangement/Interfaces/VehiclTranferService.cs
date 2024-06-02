using FleetManangement.Data;
using FleetManangement.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetManangement.Interfaces
{
    public class VehiclTranferService : IVehicletranfer
    {
        private readonly FleetDBContext _dbContext;
        public VehiclTranferService(FleetDBContext db)
        {
            _dbContext = db;
        }
        public void TranferVehicle(Vehicles vehicles,int originalcostcenter)
        {
            var vehicletranfer = new VehicleTranfer
            {
                cFromCostcentre = vehicles.CostCentre,
                cToCostcentre = vehicles.CostCentre,
                iReasonid = 1,
                iCarid=vehicles.id


            }
            ;

            _dbContext.vehicleTranfers.Add(vehicletranfer);
            try
            {
                _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Log exception or handle accordingly
                throw new Exception("Error creating vehicle", ex);
            }
        }
    }
}
