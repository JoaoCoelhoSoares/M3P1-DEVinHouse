using DEVinCar.Models;

namespace DEVinCar.Seeds
{
    public static class UsersSeeds
    {
        public static List<User> UserSeeder { get; set; } = new List<User>
        {
            new User{
                Id = 1,
                Nome = "Yan",
                Email = "yan@email.com",
                Password="123456"
            },
            new User{
                Id = 2,
                Nome = "Joao",
                Email = "joao@email.com",
                Password = "123123"
            },
            new User{
                Id = 3,
                Nome = "Support",
                Email = "support@email.com",
                Password = "123123"
            }
        };
    }
}
