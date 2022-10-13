namespace DEVinCar.Models
{
    public class CreateCaminhoneteDTO
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Cor { get; set; }
        public int Potencia { get; set; }
        public int Portas { get; set; }
        public bool Gasolisa { get; set; }
        public int CapacidadeCacamba { get; set; }

        public CreateCaminhoneteDTO(string nome, decimal valor, string cor, int potencia, int portas, int capacidadeCacamba, bool gasolisa = true)
        {
            Portas = portas;
            Gasolisa = gasolisa;
            CapacidadeCacamba = capacidadeCacamba;
            Nome = nome;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
        }
    }
}

