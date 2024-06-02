using FleetManangement.Data;
using FleetManangement.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetManangement.Interfaces
{
    public class VehicletripsService : IVehicleTripsInterface


    {

        private readonly FleetDBContext _dBContext;

        public VehicletripsService(FleetDBContext dBContext)
        {
            this._dBContext = dBContext;
        }
        public VehicleTrips CreateTrips(VehicleTrips vehicleTrips)
        {
            _dBContext.vehicleTrips.Add(vehicleTrips);
            _dBContext.SaveChanges();


            return vehicleTrips;
        }

        public IEnumerable<VehicleTrips> GetVehicleTrips()
        {
            return _dBContext.vehicleTrips.ToList();
        }
    }
    }

   
    
      


    

      
    

