using Maintenance.WebAPI.Models;

namespace Maintenance.WebAPI.Services
{
    public class FakeRepairHistoryService: IRepairHistoryService
    {
        public List<RepairHistoryDto> GetByVehicleId(int vehicleId)
        {
            var repairs = new List<RepairHistoryDto>
            {
                new RepairHistoryDto
                {
                    Id = 1,
                    VehicleId = vehicleId,
                    RepairDate = DateTime.Now.AddDays(-12),
                    Description = "Oil change",
                    Cost = 85.50m,
                    PerformedBy = "Downtown Auto Service"
                },
                new RepairHistoryDto
                {
                    Id = 2,
                    VehicleId = vehicleId,
                    RepairDate = DateTime.Now.AddDays(-35),
                    Description = "Brake pad replacement",
                    Cost = 340.00m,
                    PerformedBy = "Auto Repair Pro"
                }
            };

            return repairs;
        }
    }
}
