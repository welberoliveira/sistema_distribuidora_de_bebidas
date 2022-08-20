using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.State;
public class AddressTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Address")]
    public void Instaciate()
    {
        //Arrange
        String addressField = "Rua A";
        String number = "1010";
        String note = "Teste de obserção";
        String zipCode = "39400000";
        String stateName = "Minas Gerais";
        String stateAbreviation = "MG";
        String cityName = "Ubá";

        //Act
        var state = new DomainEntity.State(stateName, stateAbreviation);
        var city = new DomainEntity.City(cityName, state);
        var address = new DomainEntity.Address(addressField, number, note, zipCode);

        //Assert
        state.Should().NotBeNull();
        city.Should().NotBeNull();
        address.Should().NotBeNull();
        address.addressField.Should().Be(addressField);
        address.number.Should().Be(number);
        address.note.Should().Be(note);
        address.zipCode.Should().Be(zipCode);
    }
}
