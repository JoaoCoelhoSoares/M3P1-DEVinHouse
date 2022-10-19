using DEVinCar.Models;
using DEVinCar.GraphQL.Mutations;
using DEVinCar.Context;

namespace DEVinCar.Repositories
{
    public class UserRepository : IUserRepository
    {

        public DEVInCarContext _context;

        public IList<User> _users = new List<User> { };

        private List<User> users = new List<User>
        {
            new User{
                Id = 1,
                Nome = "Yan",
                Email = "yan@email.com",
                Password="123456"
            },
            new User{
                Id = 2,
                Nome = "Marco",
                Email = "marco@email.com",
                Password = "abcdef"
            },
            new User{
                Id = 3,
                Nome = "Joao",
                Email = "joao@email.com",
                Password = "123123"
            }
        };

        public UserRepository(DEVInCarContext context)
        {
            _context = context;
        }

        public User? AuthUser(LoginInput login)
        {
            var user = _context.Users.Where(_ => _.Email.ToLower() == login.Email.ToLower() &&
                        _.Password == login.Password).FirstOrDefault();

            return user;
        }

        public User GetUser(int id)
        {
            return _context.Users.Single(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

    }
}

