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
    public class SaleMutation
    {
        [GraphQLName("VenderVeiculo")]
        [Authorize]
        public async Task<CreateSaleDTO> AddVehicleSale(
            string idVehicle, long cpfComprador, DateTime dataVenda, [Service] ISaleRepository saleRepository,
            [Service] ITopicEventSender eventSender)
        {
            CreateSaleDTO newSale = await saleRepository.AddVehicleSale(idVehicle, cpfComprador, dataVenda);

            await eventSender.SendAsync(newSale, newSale.Vehicle.Tipo);
            await eventSender.SendAsync(nameof(SalesSubscriptions.VehicleSale), newSale).ConfigureAwait(false);

            return newSale;
        }
    }
}
