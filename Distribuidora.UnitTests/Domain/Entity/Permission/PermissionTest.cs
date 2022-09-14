using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Permission;
public class PermissionTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Permission")]
    public void Instaciate()
    {
        //Arrange
        String Name = "Administrador";

        //Act
        var state = new DomainEntity.Permission(Name);

        //Assert
        state.Should().NotBeNull();
        state.Name.Should().Be(Name);
    }
}
