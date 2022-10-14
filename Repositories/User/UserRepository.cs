using DEVinCar.Models;
using DEVinCar.GraphQL.Mutations;

namespace DEVinCar.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
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

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User? AuthUser(LoginInput login)
        {
            var user = _users.Where(_ => _.Email.ToLower() == login.Email.ToLower() &&
                        _.Password == login.Password).FirstOrDefault();

            return user;
        }

        public User GetUser(int id)
        {
            return _users.Single(q => q.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _users.Where(_ => _.Email.Contains(""));
        }
    }
}

