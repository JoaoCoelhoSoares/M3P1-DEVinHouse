namespace DEVinCar.Models
{
    public class CreateSaleDTO
    {
        public Sale Sale { get; set; }

        public IVehicle Vehicle { get; set; }

        public CreateSaleDTO(Sale sale, IVehicle vehicle)
        {
            Sale = sale;
            Vehicle = vehicle;
        }

    }
}
