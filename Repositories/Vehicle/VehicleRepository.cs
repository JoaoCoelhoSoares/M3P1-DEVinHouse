using System.Linq;
using DEVinCar.Context;
using DEVinCar.Models;

namespace DEVinCar.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public DEVInCarContext _context;

        public VehicleRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public IVehicle GetVehicle(string id)
        {
            IVehicle vehicleById;

            switch (id)
            {
                case string s when s.Contains("CAR"):
                    vehicleById = _context.Carros.Single(c => c.Id == id);
                    if (vehicleById is not null) return vehicleById;
                    break;
                case string s when s.Contains("CAM"):
                    vehicleById = _context.Caminhonetes.Single(c => c.Id == id);
                    if (vehicleById is not null) return vehicleById;
                    break;
                case string s when s.Contains("MOT"):
                    vehicleById = _context.MotoTriciclos.Single(c => c.Id == id);
                    if (vehicleById is not null) return vehicleById;
                    break;
                default:
                    break;
            }
             throw new Exception("erro no id");
        }

        public IEnumerable<IVehicle> GetVehicles(VehicleType? vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Carro:
                    return _context.Carros.ToList();
                case VehicleType.Caminhonete:
                    return _context.Caminhonetes.ToList();
                case VehicleType.MotoTriciclo:
                    return _context.MotoTriciclos.ToList();
                default:
                    IEnumerable<IVehicle> listCar = _context.Carros.ToList();
                    IEnumerable<IVehicle> listCam = _context.Caminhonetes.ToList();
                    IEnumerable<IVehicle> listMot = _context.MotoTriciclos.ToList();
                    var listVehicles = (listCar ?? Enumerable.Empty<IVehicle>()).Concat(listCam ?? Enumerable.Empty<IVehicle>())
                        .Concat(listMot ?? Enumerable.Empty<IVehicle>());
                    return listVehicles;
            }
        }

        public IEnumerable<IVehicle> GetAvailableVehicles(VehicleType? vehicleType)
        {
              switch (vehicleType)
            {
                case VehicleType.Carro:
                    return _context.Carros.Where(v => v.CpfComprador.Equals(0)).ToList();
                case VehicleType.Caminhonete:
                    return _context.Caminhonetes.Where(v => v.CpfComprador.Equals(0)).ToList();
                case VehicleType.MotoTriciclo:
                    return _context.MotoTriciclos.Where(v => v.CpfComprador.Equals(0)).ToList();
                default:
                    IEnumerable<IVehicle> listCar = _context.Carros.Where(v => v.CpfComprador.Equals(0)).ToList();
                    IEnumerable<IVehicle> listCam = _context.Caminhonetes.Where(v => v.CpfComprador.Equals(0)).ToList();
                    IEnumerable<IVehicle> listMot = _context.MotoTriciclos.Where(v => v.CpfComprador.Equals(0)).ToList();
                    var listVehicles = (listCar ?? Enumerable.Empty<IVehicle>()).Concat(listCam ?? Enumerable.Empty<IVehicle>())
                        .Concat(listMot ?? Enumerable.Empty<IVehicle>());
                    return listVehicles;
            }   
        }

        public async Task<string> ChangeVehicleColor(string idVehicle, string cor)
        {

            string result;

            switch (idVehicle)
            {
                case string s when s.Contains("CAR"):
                    var carro = _context.Carros.SingleOrDefault(v => v.Id.Equals(idVehicle));
                    carro.Cor = cor;
                    _context.Update(carro);

                    await _context.SaveChangesAsync();
                    result = "o veículo de id " + carro.Id + " teve sua cor atualizada para: " + carro.Cor;
                    break;
                case string s when s.Contains("CAM"):
                    var caminhonete = _context.Caminhonetes.SingleOrDefault(v => v.Id.Equals(idVehicle));
                    caminhonete.Cor = cor;
                    _context.Update(caminhonete);

                    await _context.SaveChangesAsync();
                    result = "o veículo de id " + caminhonete.Id + " teve sua cor atualizada para: " + caminhonete.Cor;
                    break;
                case string s when s.Contains("MOT"):
                    var motoTriciclo = _context.MotoTriciclos.SingleOrDefault(v => v.Id.Equals(idVehicle));
                    motoTriciclo.Cor = cor;
                    _context.Update(motoTriciclo);

                    await _context.SaveChangesAsync();
                    result = "o veículo de id " + motoTriciclo.Id + " teve sua cor atualizada para: " + motoTriciclo.Cor;
                    break;
                default:
                    result = "Alteração não realizada (idVehicle não encontrado).";
                    break;
            }
            return result;
        }

        public async Task<string> ChangeVehicleValue(string idVehicle, decimal valor)
        {
            string result = "";

            switch (idVehicle)
            {
                case string s when s.Contains("CAR"):
                    var carro = _context.Carros.SingleOrDefault(v => v.Id.Equals(idVehicle));
                    carro.Valor = valor;
                    _context.Update(carro);

                    await _context.SaveChangesAsync();
                    result = "o veículo de id " + carro.Id + " teve seu valor atualizado para: " + carro.Valor;
                    break;
                case string s when s.Contains("CAM"):
                    var caminhonete = _context.Caminhonetes.SingleOrDefault(v => v.Id.Equals(idVehicle));
                    caminhonete.Valor = valor;
                    _context.Update(caminhonete);

                    await _context.SaveChangesAsync();
                    result = "o veículo de id " + caminhonete.Id + " teve seu valor atualizado para: " + caminhonete.Valor;
                    break;
                case string s when s.Contains("MOT"):
                    var motoTriciclo = _context.MotoTriciclos.SingleOrDefault(v => v.Id.Equals(idVehicle));
                    motoTriciclo.Valor = valor;
                    _context.Update(motoTriciclo);

                    await _context.SaveChangesAsync();
                    result = "o veículo de id " + motoTriciclo.Id + " teve seu valor atualizado para: " + motoTriciclo.Valor;
                    break;
                default:
                    result = "Alteração não realizada (idVehicle não encontrado).";
                    break;
            }

            return result;
        }
    
    }
}
