using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace FleetManangement.Models
{
    public class Vehicles
    {
        [Key]
        public int id { get; set; }
        public string Provincial_Office { get; set; }
        public String Local_Office { get; set; }
        public string Make { get; set; }

        public int CostCentre {  get; set; }
         public int Engine_Capacity { get; set; }

        public string Colour { get; set; }
        public string Registration_Number { get; set; }

        public  string  Asset_Number { get; set; }
        public  String  Purchase_Year { get; set; }

        public string VehicleRegDate { get; set; }

        public string CARPSatus { get; set; }





    }

        
}
