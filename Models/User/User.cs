using HotChocolate.AspNetCore.Authorization;

namespace DEVinCar.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }

        [Authorize]
        public string? Email { get; set; }

        [Authorize]
        public string? Password { get; set; }
    }
}

