using AppService.Cqrs.Api.Commands.User;
using AppService.Cqrs.Api.Contract;
using AppService.Cqrs.Api.Handlers.User;
using Domain.Cqrs.Api.Entities.User;
using Moq;

namespace TestAll
{
    public class AppServiceTests
    {
        private AddUserCommandHandler _addUserCommandHandler;
        private readonly Mock<IRepository<Users>> _repoMock;
        private CancellationTokenSource _tokenSource;
        public AppServiceTests()
        {
            _repoMock = new Mock<IRepository<Users>>();
            _tokenSource = new CancellationTokenSource();
        }

        [Fact]
        public async Task Should_Add_New_User()
        {
            //Arrange
            _addUserCommandHandler = new AddUserCommandHandler(_repoMock.Object);
            var request = new AddUserCommand("ali", "khancherli", "0123456789");
            //Act
            var result = await _addUserCommandHandler.Handle(request, _tokenSource.Token);
            //Assert
            Assert.True(result.Result);
        }
    }
}
