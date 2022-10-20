using DEVinCar.Models;

namespace DEVinCar.Repositories
{
    public interface ISaleRepository
    {
        Task<SaleDTO> AddVehicleSale(string idVehicle, long cpfComprador, DateTime dataVenda);

        IEnumerable<ISale> GetSales(VehicleType? vehicleType);

        SaleDTO GetHigherSale(VehicleType? vehicleType);

        SaleDTO GetLowerSale(VehicleType? vehicleType);

    }
}
