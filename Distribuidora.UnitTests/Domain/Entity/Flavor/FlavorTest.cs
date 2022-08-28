using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Flavor;
public class FlavorTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Flavor")]
    public void Instaciate()
    {
        //Arrange
        int sweetened = 0;
        int bitter = 1;
        int fruity = 2;
        int smooth = 3;

        //Act
        var flavor = new DomainEntity.Flavor(sweetened, bitter, fruity, smooth);

        //Assert
        flavor.Should().NotBeNull();
        flavor.Sweetened.Should().Be(sweetened);
        flavor.Bitter.Should().Be(bitter);
        flavor.Fruity.Should().Be(fruity);
        flavor.Smooth.Should().Be(smooth);
    }
}
