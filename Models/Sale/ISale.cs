namespace DEVinCar.Models
{
    public interface ISale
    {
        public string VehicleId { get; set; }
        public DateTime DataVenda { get; set; }
        public long CpfComprador { get; }
        public decimal Valor { get; set; }
        public VehicleType? VehicleType { get; set; }

    }
}
