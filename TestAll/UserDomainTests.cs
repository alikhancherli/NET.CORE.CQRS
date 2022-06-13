using Domain.Cqrs.Api.Entities.User;

namespace TestAll
{
    public class UserDomainTests
    {
        public UserDomainTests()
        {

        }

        [Fact]
        public void Should_Make_New_Object()
        {
            //Arrange
            var user = Users.New("Ali", "Khancherli", "0123456789");
            //Act

            //Assert
            Assert.NotNull(user);
        }

        [Theory]
        [InlineData(null, "Khancherli", "0123456789")]
        [InlineData("Ali", null, "0123456789")]
        [InlineData("Ali", "Khancherli", null)]
        public void Should_Throws_Error_For_Args(string name, string family, string nationalCode) =>
            Assert.Throws<ArgumentNullException>(() => Users.New(name, family, nationalCode));

    }
}
