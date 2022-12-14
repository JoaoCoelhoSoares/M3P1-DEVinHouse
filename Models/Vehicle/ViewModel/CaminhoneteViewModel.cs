namespace DEVinCar.Models
{
    public class CaminhoneteViewModel : IVehicle
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

        public CaminhoneteViewModel(string id, string numeroChassi, DateTime dataFabricacao, string placa, long cpfComprador, string nome, decimal valor, string cor, int potencia, int portas, int capacidadeCacamba, bool gasolisa)
        {
            Portas = portas;
            Gasolisa = gasolisa;
            CapacidadeCacamba = capacidadeCacamba;
            Id = id;
            NumeroChassi = numeroChassi;
            DataFabricacao = dataFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            Tipo = "Caminhonete";
            CpfComprador = cpfComprador;
        }
    }
}
