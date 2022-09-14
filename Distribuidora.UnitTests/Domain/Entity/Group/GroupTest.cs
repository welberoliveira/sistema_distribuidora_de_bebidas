using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Group;
public class GroupTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Group")]
    public void Instaciate()
    {
        //Arrange
        String groupName = "Gestores";
        String permissionName = "Administrador";

        //Act
        var permission = new DomainEntity.Permission(permissionName);
        var group = new DomainEntity.Group(groupName, permission);

        //Assert
        permission.Should().NotBeNull();
        group.Should().NotBeNull();
        group.Name.Should().Be(groupName);
    }
}
