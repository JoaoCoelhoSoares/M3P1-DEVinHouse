namespace DEVinCar.Models
{
    public class Sale : ISale
    {
        public int Id { get; set; }
        public string VehicleId { get; set; }
        public DateTime DataVenda { get; set; }
        public long CpfComprador { get; set; }
        public decimal Valor { get; set; }
        public VehicleType? VehicleType { get; set; }


        public Sale(string vehicleId, DateTime dataVenda, long cpfComprador, decimal valor, VehicleType? vehicleType)
        {
            VehicleId = vehicleId;
            DataVenda = dataVenda;
            CpfComprador = cpfComprador;
            Valor = valor;
            VehicleType = vehicleType;
        }
    }
}
