using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.ClientType;
public class ClientTypeTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "ClientTest")]
    public void Instaciate()
    {
        //Arrange
        int NormalPerson = 123;
        int LegalPerson = 456;
        
        //Act
        var clientType= new DomainEntity.ClientType(NormalPerson, LegalPerson);

        //Assert
        clientType.Should().NotBeNull();
        clientType.NormalPerson.Should().Be(NormalPerson);
        clientType.LegalPerson.Should().Be(LegalPerson);
    }
}