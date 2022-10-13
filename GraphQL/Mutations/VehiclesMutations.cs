using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Subscriptions;
using HotChocolate.AspNetCore.Authorization;
using DEVinCar.Repositories;
using DEVinCar.Models;
using DEVinCar.GraphQL.Subscriptions;
using DEVinCar.Context;

namespace DEVinCar.GraphQL.Mutations
{

    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VehiclesMutations
    {


        [GraphQLName("AlterarCor")]
        public async Task<string> ChangeVehicleColor(
            string idVehicle, string cor, [Service] IVehicleRepository repository) => 
            await repository.ChangeVehicleColor(idVehicle, cor);

        [GraphQLName("AlterarValor")]
        public async Task<string> ChangeVehicleValue(
            string idVehicle, decimal value, [Service] IVehicleRepository repository) => 
            await repository.ChangeVehicleValue(idVehicle, value);
    }
}
