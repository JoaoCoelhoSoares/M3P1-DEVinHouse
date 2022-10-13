using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Subscriptions;
using HotChocolate.AspNetCore.Authorization;
using DEVinCar.Models;
using DEVinCar.GraphQL.Subscriptions;
using DEVinCar.Context;

namespace DEVinCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class CreateVehiclesMutations
    {
        [GraphQLName("NovoCarro")]
        public async Task<CreateCarroDTO> CreateCarro(
            CreateCarroDTO input, [Service] DEVInCarContext context,
            [Service] ITopicEventSender eventSender)
        {
            int vehicleSizeList = context.Carros.Count();

            Carro vehicle = new Carro(("CAR" + (vehicleSizeList + 1)), input.Nome, input.Valor, input.Cor, input.Potencia, input.Portas, input.Gasolisa);
            context.Carros.Add(vehicle);

            await context.SaveChangesAsync();

            await eventSender.SendAsync(VehicleType.Carro, vehicle);
            await eventSender.SendAsync(nameof(VehiclesSubscriptions.VehicleAdded), (IVehicle)vehicle).ConfigureAwait(false);

            return input;
        }

        [GraphQLName("NovaCaminhonete")]
        public async Task<CreateCaminhoneteDTO> CreateCaminhonete(
            CreateCaminhoneteDTO input, [Service] DEVInCarContext context,
            [Service] ITopicEventSender eventSender)
        {
            int vehicleSizeList = context.Caminhonetes.Count();

            Caminhonete vehicle = new Caminhonete(("CAM" + (vehicleSizeList + 1)), input.Nome, input.Valor, input.Cor, input.Potencia, input.Portas, input.CapacidadeCacamba, input.Gasolisa);
            context.Caminhonetes.Add(vehicle);

            await context.SaveChangesAsync();

            await eventSender.SendAsync(VehicleType.Caminhonete, vehicle);
            await eventSender.SendAsync(nameof(VehiclesSubscriptions.VehicleAdded), (IVehicle)vehicle).ConfigureAwait(false);

            return input;
        }

        [GraphQLName("NovaMotoTriciclo")]
        public async Task<CreateMotoTricicloDTO> CreateMotoTriciclo(
            CreateMotoTricicloDTO input, [Service] DEVInCarContext context,
            [Service] ITopicEventSender eventSender)
        {
            int vehicleSizeList = context.MotoTriciclos.Count();

            MotoTriciclo vehicle = new MotoTriciclo(("MOT" + (vehicleSizeList + 1)), input.Nome, input.Valor, input.Cor, input.Potencia, input.Rodas);
            context.MotoTriciclos.Add(vehicle);

            await context.SaveChangesAsync();

            await eventSender.SendAsync(VehicleType.MotoTriciclo, vehicle);
            await eventSender.SendAsync(nameof(VehiclesSubscriptions.VehicleAdded), (IVehicle)vehicle).ConfigureAwait(false);

            return input;
        }
    }
}
