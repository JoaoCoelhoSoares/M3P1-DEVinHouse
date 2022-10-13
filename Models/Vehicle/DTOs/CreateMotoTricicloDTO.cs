namespace DEVinCar.Models
{
    public class CreateMotoTricicloDTO
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Cor { get; set; }
        public int Potencia { get; set; }
        public int Rodas { get; set; }

        public CreateMotoTricicloDTO(string nome, decimal valor, string cor, int potencia, int rodas)
        {
            Rodas = rodas;
            Nome = nome;
            Valor = valor;
            Cor = cor;
            Potencia = potencia;
        }
    }
}
