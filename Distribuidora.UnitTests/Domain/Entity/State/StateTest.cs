using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.State;
public class StateTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "State")]
    public void Instaciate()
    {
        //Arrange
        String Name = "Minas Gerais";
        String Abreviation = "MG";

        //Act
        var state = new DomainEntity.State(Name, Abreviation);

        //Assert
        state.Should().NotBeNull();
        state.Name.Should().Be(Name);
        state.Abreviation.Should().Be(Abreviation);
    }
}
