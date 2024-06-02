using FleetManangement.Interfaces;
using FleetManangement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostCentreController : ControllerBase
    {
        IcostCentreInterface _costcentreservice;
        public CostCentreController(IcostCentreInterface CostcentreService)
        {
            _costcentreservice = CostcentreService;
        }



        [HttpGet]

        public IEnumerable<CostCentre> GetCostCentre()
        {
            return _costcentreservice.GetCostCentre();
        }

        [HttpPost]
        public CostCentre CreateCostcenter(CostCentre costcentre)
        {




            return _costcentreservice.CreateCostcenter(costcentre);
        }

    }
}
