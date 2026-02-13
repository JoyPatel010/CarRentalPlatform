using Microsoft.AspNetCore.Mvc;
using Maintenance.WebAPI.Services;


namespace Maintenance.WebAPI.Controllers
{
    [ApiController]
    [Route("api/maintenance")]
    public class MaintenanceController : ControllerBase
    {
        private readonly IRepairHistoryService _repairService;


        public MaintenanceController(IRepairHistoryService repairService)
        {
            _repairService = repairService;
        }


        [HttpGet("vehicles/{vehicleId}/repairs")]
        public IActionResult GetRepairHistory(int vehicleId)
        {
            var history = _repairService.GetByVehicleId(vehicleId);
            return Ok(history);
        }
    }
}
