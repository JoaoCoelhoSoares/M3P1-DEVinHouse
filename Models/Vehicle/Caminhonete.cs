namespace DEVinCar.Models
{
    public class Caminhonete : IVehicle
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

        public int Portas { get; set; }
        public bool Gasolisa { get; set; }
        public int CapacidadeCacamba { get; set; }


        public Caminhonete(string id, string nome, decimal valor, string cor, int potencia, int portas, int capacidadeCacamba, bool gasolisa = true)
        {
            Portas = portas;
            Gasolisa = gasolisa;
            CapacidadeCacamba = capacidadeCacamba;

            Id = id;
            NumeroChassi = IVehicle.ChassiGenerator();
            //DataFabricacao = DateOnly.FromDateTime(DateTime.Now.AddDays(-1));
            DataFabricacao = DateTime.Now.AddDays(-1);
            Nome = nome;
            Placa = IVehicle.PlacaGenerator();
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            Tipo = "Caminhonete";
            CpfComprador = 0;

        }
    }
}
