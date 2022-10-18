﻿using DEVinCar.Models;

namespace DEVinCar.Repositories
{
    public interface ISaleRepository
    {
        Task<CreateSaleDTO> AddVehicleSale(string idVehicle, long cpfComprador, DateTime dataVenda);

        IEnumerable<ISale> GetSales(VehicleType? vehicleType);

        ISale GetHigherSale(VehicleType? vehicleType);

        ISale GetLowerSale(VehicleType? vehicleType);

    }
}
