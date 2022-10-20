using System.Linq;
using DEVinCar.Context;
using DEVinCar.Models;

namespace DEVinCar.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        public DEVInCarContext _context;

        public IList<Sale> _sales = new List<Sale> { };

        public SaleRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public async Task<SaleDTO> AddVehicleSale(string idVehicle, long cpfComprador, DateTime dataVenda)
        {
            VehicleType vehicleType = VehicleType.Carro;
            decimal vehicleValue = 0;          
            IVehicle vehicle = null;

            switch (idVehicle)
            {
                case string s when s.Contains("CAR"):
                    var carro = _context.Carros.SingleOrDefault(v => v.Id.Contains(idVehicle));
                    if(carro is null) break;
                    carro.CpfComprador = cpfComprador;
                    vehicleValue = carro.Valor;
                    _context.Update(carro);
                    await _context.SaveChangesAsync();
                    vehicle = carro;

                    break;
                case string s when s.Contains("CAM"):
                    var caminhonete = _context.Caminhonetes.SingleOrDefault(v => v.Id.Contains(idVehicle));
                    if (caminhonete is null) break;
                    caminhonete.CpfComprador = cpfComprador;
                    vehicleValue = caminhonete.Valor;
                    _context.Update(caminhonete);
                    vehicleType = VehicleType.Caminhonete;

                    await _context.SaveChangesAsync();
                    vehicle = caminhonete;

                    break;
                case string s when s.Contains("MOT"):
                    var motoTriciclo = _context.MotoTriciclos.SingleOrDefault(v => v.Id.Contains(idVehicle));
                    if (motoTriciclo is null) break;
                    motoTriciclo.CpfComprador = cpfComprador;
                    vehicleValue = motoTriciclo.Valor;
                    _context.Update(motoTriciclo);
                    vehicleType = VehicleType.MotoTriciclo;
                    
                    await _context.SaveChangesAsync();
                    vehicle = motoTriciclo;

                    break;
                default:
                    break;
            }

            if(vehicleValue > 0) {
                Sale newSale = new Sale(idVehicle, dataVenda, cpfComprador, vehicleValue, vehicleType);
                SaleDTO createSale = new (newSale, vehicle);
                _context.Sales.Add(newSale);
                await _context.SaveChangesAsync();
                return createSale;
             };       

            return null;
        }

        public SaleDTO GetHigherSale(VehicleType? vehicleType)
        {
            ISale higherSale;
            if (vehicleType == null)
            {
                higherSale = _context.Sales.OrderByDescending(s => s.Valor).First();
            } else {
                higherSale = _context.Sales.Where(v => v.VehicleType.Equals(vehicleType)).OrderByDescending(s => s.Valor).First();
            }
            IVehicle vehicleSale = null;

            switch (higherSale.VehicleId)
            {
                case string s when s.Contains("CAR"):
                    vehicleSale = _context.Carros.SingleOrDefault(v => v.Id.Contains(higherSale.VehicleId));

                    break;
                case string s when s.Contains("CAM"):
                    vehicleSale = _context.Caminhonetes.SingleOrDefault(v => v.Id.Contains(higherSale.VehicleId));
                  
                    break;
                case string s when s.Contains("MOT"):
                    vehicleSale = _context.MotoTriciclos.SingleOrDefault(v => v.Id.Contains(higherSale.VehicleId));
                   
                    break;
                default:
                    break;
            }

            SaleDTO saleDTO = new((Sale)higherSale, vehicleSale);
            return saleDTO;
        }

        public SaleDTO GetLowerSale(VehicleType? vehicleType)
        {
            ISale lowerSale;
            if (vehicleType == null)
            {
                lowerSale = _context.Sales.OrderBy(s => s.Valor).First();
            }
            else
            {
                lowerSale = _context.Sales.Where(v => v.VehicleType.Equals(vehicleType)).OrderBy(s => s.Valor).First();
            }
            IVehicle vehicleSale = null;

            switch (lowerSale.VehicleId)
            {
                case string s when s.Contains("CAR"):
                    vehicleSale = _context.Carros.SingleOrDefault(v => v.Id.Contains(lowerSale.VehicleId));

                    break;
                case string s when s.Contains("CAM"):
                    vehicleSale = _context.Caminhonetes.SingleOrDefault(v => v.Id.Contains(lowerSale.VehicleId));

                    break;
                case string s when s.Contains("MOT"):
                    vehicleSale = _context.MotoTriciclos.SingleOrDefault(v => v.Id.Contains(lowerSale.VehicleId));

                    break;
                default:
                    break;
            }

            SaleDTO saleDTO = new((Sale)lowerSale, vehicleSale);
            return saleDTO;
        }

        public IEnumerable<ISale> GetSales(VehicleType? vehicleType)
        {
            if(vehicleType == null) return _context.Sales.ToList();
            IEnumerable<ISale> vehicleList = _context.Sales.Where(v => v.VehicleType.Equals(vehicleType)).ToList();
            return vehicleList;
        }
    }
}
