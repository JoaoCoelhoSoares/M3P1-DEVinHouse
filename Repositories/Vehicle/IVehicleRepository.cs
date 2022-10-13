using DEVinCar.Models;

namespace DEVinCar.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<IVehicle> GetVehicles(VehicleType? vehicleType);

        IVehicle GetVehicle(string id);

        IEnumerable<IVehicle> GetAvailableVehicles(VehicleType? vehicleType);

        Task<string> ChangeVehicleColor(string idVehicle, string cor);

        Task<string> ChangeVehicleValue(string idVehicle, decimal valor);

    }
}
