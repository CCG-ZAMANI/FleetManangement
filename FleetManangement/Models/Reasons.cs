using System.ComponentModel.DataAnnotations;

namespace FleetManangement.Models
{
    public class Reasons
    {
        [Key]
        public int Id { get; set; }
        public string cReason {  get; set; }

        public string description { get; set; }

    }
}
