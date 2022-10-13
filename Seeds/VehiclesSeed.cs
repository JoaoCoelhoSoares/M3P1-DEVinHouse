using DEVinCar.Models;

namespace DEVinCar.Seeds
{
    public static class VehiclesSeed
    {
        public static List<Carro> CarroSeeder { get; set; } = new List<Carro>()
        {
        new Carro("CAR1", "Ford Focus", 45000, "Cinza", 250, 4, false),
        new Carro("CAR2", "Punto", 47500, "Branco", 350, 2, false),
        new Carro("CAR3", "Gol", 30000, "Azul", 200, 4, false)
         };

        public static List<Caminhonete> CaminhoneteSeeder { get; set; } = new List<Caminhonete>()
        {
        new Caminhonete("CAM1", "F1000", 60000, "Verde", 1000, 2, 300, false),
        new Caminhonete("CAM2", "F500", 55000, "Cinza", 500, 2, 250, false),
        new Caminhonete("CAM3", "F250", 45000, "Preto", 250, 2, 250, true)
         };

        public static List<MotoTriciclo> MotoTricicloSeeder { get; set; } = new List<MotoTriciclo>()
        {
        new MotoTriciclo("MOT1", "CG150", 8500, "Vermelho", 150, 2),
        new MotoTriciclo("MOT2", "Honda Biz", 5500, "Branco", 100, 2),
        new MotoTriciclo("MOT3", "Triciclo 3E", 11500, "Azul", 125, 3),
         };
    }
}
