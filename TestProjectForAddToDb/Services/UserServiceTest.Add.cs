using AddtoDbWithxUnit.Models;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using System.Threading.Tasks;

namespace TestProjectForAddToDb.Services
{
    public partial class UserServiceTest
    {
        [Fact]
        public async Task ShouldAddUser()
        {
            // given
            User randomUser = CreateRandomUser();
            User inputUser = randomUser;
            User persistedUser = inputUser;
            User expectedUser = persistedUser.DeepClone();

            this.mockBroker.Setup(broker =>
                broker.AddUserAsync(inputUser))
                    .ReturnsAsync(persistedUser);

            // when
            User actualUser = await this.userService.AddUserAsync(inputUser);

            // then
            actualUser.Should().BeEquivalentTo(expectedUser);

            this.mockBroker.Verify(broker =>
                broker.AddUserAsync(inputUser), Times.Once);

            this.mockBroker.VerifyNoOtherCalls();
        }
    }
}
