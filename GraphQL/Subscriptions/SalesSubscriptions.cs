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
        public SaleDTO VehicleSale([EventMessage] SaleDTO message) => message;

        [Subscribe]
        [GraphQLName("VeiculoVendidoPorTipo")]
        public SaleDTO VehicleTypeSale([Topic] VehicleType tipo, [EventMessage] SaleDTO message) => message;
    }
}
