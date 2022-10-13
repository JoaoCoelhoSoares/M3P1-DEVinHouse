using HotChocolate.Data;
using HotChocolate;
using HotChocolate.Types;
using DEVinCar.Models;
using DEVinCar.Repositories;

namespace DEVinCar.GraphQL.Queries
{

    [ExtendObjectType(OperationTypeNames.Query)]
    public class UsersQueries
    {
        // [GraphQLName("...")]
        public IEnumerable<User> GetUsers([Service] IUserRepository repository) => repository.GetUsers();

        public User GetUser([Service] IUserRepository repository, int userID) => repository.GetUser(userID);
    }
}
