using FleetManangement.Models;

namespace FleetManangement.Interfaces
{
    public interface IcostCentreInterface
    {
        public IEnumerable<CostCentre> GetCostCentre();
        public CostCentre CreateCostcenter(CostCentre costCentre);

    }
}
