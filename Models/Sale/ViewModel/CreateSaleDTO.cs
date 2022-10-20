namespace DEVinCar.Models
{
    public class SaleDTO
    {
        public Sale Sale { get; set; }

        public IVehicle Vehicle { get; set; }

        public SaleDTO(Sale sale, IVehicle vehicle)
        {
            Sale = sale;
            Vehicle = vehicle;
        }

    }
}
