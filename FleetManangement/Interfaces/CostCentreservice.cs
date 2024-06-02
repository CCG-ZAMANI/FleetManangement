using FleetManangement.Data;
using FleetManangement.Models;
using Microsoft.EntityFrameworkCore;

namespace FleetManangement.Interfaces
{
    public class CostCentreservice : IcostCentreInterface

    {
        private readonly FleetDBContext _dBContext;

        public CostCentreservice(FleetDBContext dBContext)
        {
            this._dBContext = dBContext;
        }

        public CostCentre CreateCostcenter(CostCentre costCentre)
        {
            _dBContext.CostCentre.Add(costCentre);
            _dBContext.SaveChangesAsync();
            return costCentre;
        }

        public IEnumerable<CostCentre> GetCostCentre()
        {
            return _dBContext.CostCentre.ToList();
        }
    }

      
    
}
