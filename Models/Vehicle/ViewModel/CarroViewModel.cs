namespace DEVinCar.Models
{
    public class CarroViewModel : IVehicle
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

        public CarroViewModel(string id, string numeroChassi, DateTime dataFabricacao, string placa, long cpfComprador, string nome, decimal valor, string cor, int potencia, int portas, bool gasolisa)
        {
            Portas = portas;
            Gasolisa = gasolisa;
            Id = id;
            NumeroChassi = numeroChassi;
            DataFabricacao = dataFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            Tipo = "Carro";
            CpfComprador = cpfComprador;
        }
    }
}
