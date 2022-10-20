using HotChocolate.AspNetCore.Authorization;

namespace DEVinCar.Models
{
    [InterfaceType]
    public interface IVehicle
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

        public static string ChassiGenerator()
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHJKLMNPRSTUVWXYZ0123456789"; // as letras I, O e Q não são utilizadas no número do Chassi por serem parecidas com os números 1 e 0.
            string numChassi = "";

            for (var i = 0; i < 17; i++)
            {
                numChassi += chars[rnd.Next(chars.Length)];
            }
            //VerificarChassi(numChassi);

            return numChassi;
        }

        public static string PlacaGenerator()
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string placa = $"{chars[rnd.Next(chars.Length)]}{chars[rnd.Next(chars.Length)]}{chars[rnd.Next(chars.Length)]}-{rnd.Next(0, 9)}{rnd.Next(0, 9)}{rnd.Next(0, 9)}{rnd.Next(0, 9)}";
            //placa = VerificarPlaca(placa);
            return placa;
        }

        //public static string VerificarChassi(string chassi)
        //{
        //    Random rnd = new Random();
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //    while (Data.veiculos.Count(v => v.NumeroChassi.Equals(chassi)) > 0)
        //    {
        //        chassi = "";
        //        for (var i = 0; i < 17; i++)
        //        {
        //            chassi += chars[rnd.Next(chars.Length)];
        //        }
        //    }

        //    return chassi;
        //}

        //public static string VerificarPlaca(string placa)
        //{
        //    Random rnd = new Random();
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //    while (Data.veiculos.Count(v => v.Placa.Equals(placa)) > 0)
        //    {
        //        placa = $"{chars[rnd.Next(chars.Length)]}{chars[rnd.Next(chars.Length)]}{chars[rnd.Next(chars.Length)]}-{rnd.Next(0, 9)}{rnd.Next(0, 9)}{rnd.Next(0, 9)}{rnd.Next(0, 9)}";
        //    }

        //    return placa;
        //}
    }
}
