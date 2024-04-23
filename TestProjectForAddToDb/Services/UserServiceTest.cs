using AddtoDbWithxUnit.Brokers;
using AddtoDbWithxUnit.Models;
using AddtoDbWithxUnit.UserService;
using Moq;
using Xunit;
using Tynamix.ObjectFiller;

namespace TestProjectForAddToDb.Services
{
    public partial class UserServiceTest
    {
        private readonly Mock<IBroker> mockBroker;
        private readonly IUserService userService;

        public UserServiceTest()
        {
            this.mockBroker = new Mock<IBroker>();

            this.userService = 
                new UserService(this.mockBroker.Object);
        }

        private User CreateRandomUser() =>
            new Filler<User>().Create();
    }
}
