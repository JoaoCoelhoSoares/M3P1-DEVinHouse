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

        public async Task<Sale> AddVehicleSale(string idVehicle, long cpfComprador, DateTime dataVenda)
        {
            VehicleType vehicleType = VehicleType.Carro;
            decimal vehicleValue = 0;

            switch (idVehicle)
            {
                case string s when s.Contains("CAR"):
                    var carro = (Carro)_context.Carros.SingleOrDefault(v => v.Id.Contains(idVehicle));
                    carro.CpfComprador = cpfComprador;
                    vehicleValue = carro.Valor;
                    _context.Update(carro);

                    await _context.SaveChangesAsync();
                    break;
                case string s when s.Contains("CAM"):
                    var caminhonete = _context.Caminhonetes.SingleOrDefault(v => v.Id.Contains(idVehicle));
                    caminhonete.CpfComprador = cpfComprador;
                    vehicleValue = caminhonete.Valor;
                    _context.Update(caminhonete);
                    vehicleType = VehicleType.Caminhonete;

                    await _context.SaveChangesAsync();
                    break;
                case string s when s.Contains("MOT"):
                    var motoTriciclo = _context.MotoTriciclos.SingleOrDefault(v => v.Id.Contains(idVehicle));
                    motoTriciclo.CpfComprador = cpfComprador;
                    vehicleValue = motoTriciclo.Valor;
                    _context.Update(motoTriciclo);
                    vehicleType = VehicleType.MotoTriciclo;
                    
                    await _context.SaveChangesAsync();
                    break;
                default:
                    break;
            }
            Sale newSale = new Sale(idVehicle, dataVenda, cpfComprador, vehicleValue, vehicleType);
            
            _context.Sales.Add(newSale);
            await _context.SaveChangesAsync();

            return newSale;
        }

        public ISale GetHigherSale(VehicleType? vehicleType)
        {
            if (vehicleType == null) return _sales.MaxBy(s => s.Valor);
            
            ISale higherSale = _sales.Where(s => s.VehicleType == vehicleType).MaxBy(s => s.Valor);
            return higherSale;
        }

        public ISale GetLowerSale(VehicleType? vehicleType)
        {
            
            if (vehicleType == null) return _sales.MinBy(s => s.Valor);

            ISale lowerSale = _sales.Where(s => s.VehicleType == vehicleType).MinBy(s => s.Valor);
            if (lowerSale == null) return null;
            return lowerSale;
        }

        public IEnumerable<ISale> GetSales(VehicleType? vehicleType)
        {
            if(vehicleType == null) return _sales;
            IEnumerable<ISale> vehicleList = _sales.Where(s => s.VehicleType == vehicleType);
            return vehicleList;
        }
    }
}
