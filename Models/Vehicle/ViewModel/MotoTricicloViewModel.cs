namespace DEVinCar.Models
{
    public class MotoTricicloViewModel : IVehicle
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

        public MotoTricicloViewModel(string id, string numeroChassi, DateTime dataFabricacao, string placa, long cpfComprador, string nome, decimal valor, string cor, int potencia, int rodas)
        {
            Id = id;
            Rodas = rodas;
            NumeroChassi = numeroChassi;
            DataFabricacao = dataFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
            Tipo = "MotoTriciclo";
            CpfComprador = cpfComprador;

        }
    }
}
