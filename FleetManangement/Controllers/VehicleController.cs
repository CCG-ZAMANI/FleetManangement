using FleetManangement.Data;
using FleetManangement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.ModelBinding;
using System.Collections.Generic;
using System.Threading.Tasks;
using FleetManangement.Interfaces;
using FleetManangement.Repository;

namespace FleetManangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class VehicleController : ControllerBase
    {
        IVehicleInterface _vehicleservice;

        public VehicleController(IVehicleInterface VehicleService)
        {
            _vehicleservice = VehicleService;
        }



        [HttpGet]

        public IEnumerable<Vehicles> GetVehicles()
        {
            return _vehicleservice.GetVehicles();
        }

        [HttpPost]
        public Vehicles PostVehicle(Vehicles vehicle)
        {




            return _vehicleservice.CreateVehicle(vehicle);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] Vehicles vehicle)
        {
            if (vehicle == null || vehicle.id != id)
            {
                return BadRequest();
            }

            try
            {
                var updatedVehicle =  _vehicleservice.UpdateVehicle(vehicle);
                return Ok(updatedVehicle);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }


        }
}
    



     
    

