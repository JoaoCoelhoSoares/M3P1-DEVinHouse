using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using DEVinCar.Models;
using DEVinCar.Repositories;
using DEVinCar.Context;

namespace DEVinCar.GraphQL.Queries
{

    [ExtendObjectType(OperationTypeNames.Query)]
    public class VehiclesQueries
    {
        [GraphQLName("Veiculos")]
        public IEnumerable<IVehicle> GetVehicles([Service] IVehicleRepository repository, VehicleType? vehicleType) => repository.GetVehicles(vehicleType);

        [GraphQLName("Veiculo_id")]
        public async Task<IVehicle> GetIdVehicle([Service] IVehicleRepository repository, string vehicleId) => repository.GetVehicle(vehicleId);

        [GraphQLName("Disponiveis")]
        public async Task<IEnumerable<IVehicle>> GetAvailableVehicles([Service] IVehicleRepository repository, VehicleType? vehicleType) => repository.GetAvailableVehicles(vehicleType);
        
    }
}
