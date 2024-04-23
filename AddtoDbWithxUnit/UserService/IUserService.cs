using AddtoDbWithxUnit.Models;
using System.Threading.Tasks;

namespace AddtoDbWithxUnit.UserService
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
    }
}
