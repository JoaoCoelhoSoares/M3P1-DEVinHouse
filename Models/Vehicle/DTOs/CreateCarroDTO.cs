namespace DEVinCar.Models
{
    public class CreateCarroDTO
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Cor { get; set; }
        public int Potencia { get; set; }
        public int Portas { get; set; }
        public bool Gasolisa { get; set; }

        public CreateCarroDTO(string nome, decimal valor, string cor, int potencia, int portas, bool gasolisa = true)
        {
            Portas = portas;
            Gasolisa = gasolisa;
            Nome = nome;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
        }
    }
}
