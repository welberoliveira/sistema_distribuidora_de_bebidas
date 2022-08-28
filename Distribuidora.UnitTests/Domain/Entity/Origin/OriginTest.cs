using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Origin;
public class OriginTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Origin")]
    public void Instaciate()
    {
        //Arrange
        int national = 1;
        int foreign = 0;

        //Act
        var origin= new DomainEntity.Origin(national, foreign);

        //Assert
        origin.Should().NotBeNull();
        origin.National.Should().Be(national);
        origin.Foreign.Should().Be(foreign);
    }   
}
