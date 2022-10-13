using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using DEVinCar.Models;
using DEVinCar.Repositories;


namespace DEVinCar.GraphQL.Queries
{

    [ExtendObjectType(OperationTypeNames.Query)]
    public class SalesQueries
    {
        [GraphQLName("Vendidos")]
        [GraphQLDescription("Retorna uma lista de veículos vendidos, podendo ser inserido um tipo específico de veículo (vehicleType) para retornar a lista de apena esse tipo")]
        public IEnumerable<ISale> GetSales([Service] ISaleRepository repository, VehicleType? vehicleType) => repository.GetSales(vehicleType);

        [GraphQLName("MaiorPreco")]
        [GraphQLDescription("Retorna a venda de veículo com maior preço, podendo ser inserido um tipo específico de veículo (vehicleType) para retornar a maior venda daquele tipo")]
        public ISale GetHigherSale([Service] ISaleRepository repository, VehicleType? vehicleType) => repository.GetHigherSale(vehicleType);

        [GraphQLName("MenorPreco")]
        [GraphQLDescription("Retorna a venda de veículo com menor preço, podendo ser inserido um tipo específico de veículo (vehicleType) para retornar a menor venda daquele tipo")]

        public ISale GetLowerSale([Service] ISaleRepository repository, VehicleType? vehicleType) => repository.GetLowerSale(vehicleType);

    }
}
