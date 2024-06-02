using FleetManangement.Data;
using FleetManangement.Interfaces;
using FleetManangement.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement.Interfaces
{
    public class VehicleService : IVehicleInterface
    {
        private readonly FleetDBContext _dbContext;
        private readonly IVehicletranfer _tranfer;


        public VehicleService(FleetDBContext dbContext, IVehicletranfer tranfer)
        {
            _dbContext = dbContext;
            _tranfer = tranfer;
        }

        public Vehicles CreateVehicle(Vehicles vehicle)
        {
            _dbContext.Vehicle.Add(vehicle);
            try
            {
                _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Log exception or handle accordingly
                throw new Exception("Error creating vehicle", ex);
            }
            return vehicle;
        }

        public IEnumerable<Vehicles> GetVehicles()
        {
            return _dbContext.Vehicle.ToList();
        }

        public Vehicles UpdateVehicle(Vehicles vehicle)
        {
            var existingVehicle = _dbContext.Vehicle.Find(vehicle.id);
            var originalcostcenter = existingVehicle.CostCentre;

            if (existingVehicle == null)
            {
                throw new ArgumentException("Vehicle not found");
            }

            existingVehicle.CostCentre = vehicle.CostCentre;
            existingVehicle.Provincial_Office = vehicle.Provincial_Office;
            existingVehicle.Local_Office = vehicle.Local_Office;
            existingVehicle.VehicleRegDate = vehicle.VehicleRegDate;
            existingVehicle.Engine_Capacity = vehicle.Engine_Capacity;
            existingVehicle.Asset_Number = vehicle.Asset_Number;
            // Update other properties as needed

            try
            {
                _dbContext.SaveChangesAsync();
                _tranfer.TranferVehicle(vehicle,originalcostcenter);
                return existingVehicle;

            }


            catch (DbUpdateException ex)
            {
                // Log exception or handle accordingly
                throw new Exception("Error updating vehicle", ex);
            }
            //var tranfer = new VehicleTranfer();
            //{
            //    // Set properties of the new record using the updated data
            //    tranfer.cFromCostcentre = vehicleTranfer.cFromCostcentre;
            //    tranfer.iCarid = vehicleTranfer.iCarid;
            //    tranfer.cToCostcentre = vehicleTranfer.cToCostcentre;
            //    tranfer.TranferDescription = vehicleTranfer.TranferDescription;


            //    _dbContext.vehicleTranfers.Add(tranfer);


            //    try

            //    {
            //        _dbContext.SaveChanges();

            //    }
            //    catch (DbUpdateException ex)
            //    {
            //        // Log exception or handle accordingly
            //        throw new Exception("Error creating transfer record", ex);
            //    }

                // return tranfer;



            
        }

     
    }
}
    

