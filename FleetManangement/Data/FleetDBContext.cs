using FleetManangement.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetManangement.Data
{
    public class FleetDBContext : DbContext
    {
        public FleetDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {


        }

        public DbSet<Vehicles> Vehicle{ get; set; }
        public DbSet<CostCentre> CostCentre { get; set; }
        public DbSet<VehicleTranfer> vehicleTranfers { get; set; }
        public DbSet<VehicleTrips> vehicleTrips { get; set; }

        public DbSet<Reasons> reasons { get; set; }

     

      
    }
}
