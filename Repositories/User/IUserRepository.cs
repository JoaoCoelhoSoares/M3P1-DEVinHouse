using DEVinCar.GraphQL.Mutations;
using DEVinCar.Models;

namespace DEVinCar.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        void AddUser(User user);

        User GetUser(int id);

        User? AuthUser(LoginInput login);
    }
}
