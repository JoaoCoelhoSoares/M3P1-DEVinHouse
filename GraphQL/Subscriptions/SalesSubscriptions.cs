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
        public CreateSaleDTO VehicleSale([EventMessage] CreateSaleDTO message) => message;

        [Subscribe]
        [GraphQLName("VeiculoVendidoPorTipo")]
        public CreateSaleDTO VehicleTypeSale([Topic] VehicleType? tipo, [EventMessage] CreateSaleDTO message) => message;
    }
}
