using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.State;
public class CityTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "City")]
    public void Instaciate()
    {
        //Arrange
        String cityName = "Manga";
        String stateName = "Minas Gerais";
        String stateAbreviation = "MG";

        //Act
        var state = new DomainEntity.State(stateName, stateAbreviation);
        var city = new DomainEntity.City(cityName, state);

        //Assert
        state.Should().NotBeNull();
        city.Should().NotBeNull();
        city.Name.Should().Be(cityName);
    }
}
