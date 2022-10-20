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

        [Authorize]
        public async Task<CreateCarroDTO> CreateCarro(
            CreateCarroDTO input, [Service] DEVInCarContext context,
            [Service] ITopicEventSender eventSender)
        {
            int vehicleSizeList = context.Carros.Count();

            Carro vehicle = new Carro(("CAR" + (vehicleSizeList + 1)), input.Nome, input.Valor, input.Cor, input.Potencia, input.Portas, input.Gasolisa);
            context.Carros.Add(vehicle);

            await context.SaveChangesAsync();

            CarroViewModel vehicleviewModel = new(vehicle.Id, vehicle.NumeroChassi, vehicle.DataFabricacao, vehicle.Placa, vehicle.CpfComprador, vehicle.Nome, vehicle.Valor, vehicle.Cor, vehicle.Potencia, vehicle.Portas, vehicle.Gasolisa);
            await eventSender.SendAsync(VehicleType.Carro, (IVehicle)vehicleviewModel);
            await eventSender.SendAsync(nameof(VehiclesSubscriptions.VehicleAdded), (IVehicle)vehicleviewModel).ConfigureAwait(false);

            return input;
        }

        [GraphQLName("NovaCaminhonete")]
        [Authorize]
        public async Task<CreateCaminhoneteDTO> CreateCaminhonete(
            CreateCaminhoneteDTO input, [Service] DEVInCarContext context,
            [Service] ITopicEventSender eventSender)
        {
            int vehicleSizeList = context.Caminhonetes.Count();

            Caminhonete vehicle = new Caminhonete(("CAM" + (vehicleSizeList + 1)), input.Nome, input.Valor, input.Cor, input.Potencia, input.Portas, input.CapacidadeCacamba, input.Gasolisa);
            context.Caminhonetes.Add(vehicle);

            await context.SaveChangesAsync();

            CaminhoneteViewModel vehicleviewModel = new(vehicle.Id, vehicle.NumeroChassi, vehicle.DataFabricacao, vehicle.Placa, vehicle.CpfComprador, vehicle.Nome, vehicle.Valor, vehicle.Cor, vehicle.Potencia, vehicle.Portas, vehicle.CapacidadeCacamba, vehicle.Gasolisa);
            await eventSender.SendAsync(VehicleType.Caminhonete, (IVehicle)vehicleviewModel);
            await eventSender.SendAsync(nameof(VehiclesSubscriptions.VehicleAdded), (IVehicle)vehicleviewModel).ConfigureAwait(false);

            return input;
        }

        [GraphQLName("NovaMotoTriciclo")]
        [Authorize]
        public async Task<CreateMotoTricicloDTO> CreateMotoTriciclo(
            CreateMotoTricicloDTO input, [Service] DEVInCarContext context,
            [Service] ITopicEventSender eventSender)
        {
            int vehicleSizeList = context.MotoTriciclos.Count();

            MotoTriciclo vehicle = new MotoTriciclo(("MOT" + (vehicleSizeList + 1)), input.Nome, input.Valor, input.Cor, input.Potencia, input.Rodas);
            context.MotoTriciclos.Add(vehicle);

            await context.SaveChangesAsync();

            MotoTricicloViewModel vehicleviewModel = new(vehicle.Id, vehicle.NumeroChassi, vehicle.DataFabricacao, vehicle.Placa, vehicle.CpfComprador, vehicle.Nome, vehicle.Valor, vehicle.Cor, vehicle.Potencia, vehicle.Rodas);

            await eventSender.SendAsync(VehicleType.MotoTriciclo, (IVehicle)vehicleviewModel);
            await eventSender.SendAsync(nameof(VehiclesSubscriptions.VehicleAdded), (IVehicle)vehicleviewModel).ConfigureAwait(false);

            return input;
        }
    }
}
