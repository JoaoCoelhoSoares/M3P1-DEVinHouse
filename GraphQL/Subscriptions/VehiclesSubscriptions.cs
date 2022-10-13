using DEVinCar.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace DEVinCar.GraphQL.Subscriptions
{

    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class VehiclesSubscriptions
    {
        [Subscribe]
        [GraphQLName("VeiculoAdicionado")]
        public IVehicle VehicleAdded([EventMessage] IVehicle message) => message;

        [Subscribe]
        [GraphQLName("VeiculoAdicionadoPorTipo")]
        public IVehicle VehicleTypeAdded([Topic] VehicleType? tipo, [EventMessage] IVehicle message) => message;

    }
}
