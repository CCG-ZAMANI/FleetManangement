using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace FleetManangement.Models
{
    public class VehicleTrips
    {
        [Key]
        public int Id { get; set; }
        public int Carid { get; set; }
        public int openingReading { get; set; }
        public int closingReading { get; set; }

        public int quantity { get; set; }

        public int distance { get; set; }
         
         public int Price { get; set; }

    }
}

