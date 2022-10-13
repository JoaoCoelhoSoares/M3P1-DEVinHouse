using DEVinCar.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace DEVinCar.GraphQL.Subscriptions
{

    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class SalesSubscriptions
    {

        [Subscribe]
        [GraphQLName("VeiculoVendido")]
        public Sale VehicleSale([EventMessage] Sale message) => message;

        [Subscribe]
        [GraphQLName("VeiculoVendidoPorTipo")]
        public Sale VehicleTypeSale([Topic] VehicleType? tipo, [EventMessage] Sale message) => message;
    }
}
