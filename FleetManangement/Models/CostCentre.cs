using System.ComponentModel.DataAnnotations;

namespace FleetManangement.Models
{
    public class CostCentre
    {
        [Key]
        public int Id { get; set; }
        public string Centre { get; set; }
        public string CentreDescription { get; set; }
       
    }
}
