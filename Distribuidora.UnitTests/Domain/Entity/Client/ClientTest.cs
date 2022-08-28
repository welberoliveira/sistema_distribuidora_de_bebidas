using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Client;
public class ClientTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Client")]
    public void Instaciate()
    {
        //Arrange
        String name = "José da Silva";
        String cpfOrCnpj = "123.654.987-87";
        String phone = "(38) 32144-6547";
        String email = "teste@gmail.com";
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
        var address = new DomainEntity.Address(addressField, number, note, zipCode, state, city);
        var clientType = new DomainEntity.ClientType(1, 0);
        var client = new DomainEntity.Client(name, cpfOrCnpj, phone, email, address, clientType);

        //Assert
        state.Should().NotBeNull();
        city.Should().NotBeNull();
        address.Should().NotBeNull();
        client.Name.Should().Be(name);
        client.CpfOrCnpj.Should().Be(cpfOrCnpj);
        client.Phone.Should().Be(phone);
        client.Email.Should().Be(email);
    }
}
