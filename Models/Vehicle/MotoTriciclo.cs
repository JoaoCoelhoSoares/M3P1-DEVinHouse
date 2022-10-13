namespace DEVinCar.Models
{
    public class MotoTriciclo : IVehicle
    {
        public string Id { get; set; }
        public string NumeroChassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public long CpfComprador { get; set; }
        public string Cor { get; set; }
        public int Potencia { get; set; }
        public string Tipo { get; set; }
        public int Rodas { get; set; }

        public MotoTriciclo(string id, string nome, decimal valor, string cor, int potencia, int rodas)
        {
            Id = id;
            Rodas = rodas;

            NumeroChassi = IVehicle.ChassiGenerator();
            //DataFabricacao = DateOnly.FromDateTime(DateTime.Now.AddDays(-1));
            DataFabricacao = DateTime.Now.AddDays(-1);
            Nome = nome;
            Placa = IVehicle.PlacaGenerator();
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            Tipo = "MotoTriciclo";
            CpfComprador = 0;

        }
    }
}
