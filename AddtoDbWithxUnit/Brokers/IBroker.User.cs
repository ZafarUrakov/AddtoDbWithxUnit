using AddtoDbWithxUnit.Models;
using System.Threading.Tasks;

namespace AddtoDbWithxUnit.Brokers
{
    public interface IBroker
    {
        ValueTask<User> AddUserAsync(User user);
    }
}
