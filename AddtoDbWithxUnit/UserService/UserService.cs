using AddtoDbWithxUnit.Brokers;
using AddtoDbWithxUnit.Models;
using System.Threading.Tasks;

namespace AddtoDbWithxUnit.UserService
{
    public class UserService : IUserService
    {
        private readonly IBroker broker;

        public UserService(IBroker broker) =>
            this.broker = broker;

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.broker.AddUserAsync(user);
    }
}
