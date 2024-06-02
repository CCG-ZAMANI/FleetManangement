using System.ComponentModel.DataAnnotations;

namespace FleetManangement.Models
{
    public class VehicleTranfer
    {
        [Key]
        public int Id { get; set; }
        public int iCarid  { get; set; }

        public string TranferDescription { get; set; }

        public int iReasonid { get; set; }
        public int cFromCostcentre {  get; set; }

        public int cToCostcentre { get; set; }

        
    }
}
