using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;
using Bogus;

namespace Distribuidora.UnitTests.Domain.Entity.Sale;
public class SaleTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Sale")]
    public void Instaciate()
    {
        //Arrange Product
        String sku = "Lata";
        String productName = "Bhrama";
        String picture = "as65df4a6sd54f6asd54fa6sd54f";
        double price = 5.25;
        double alcoholContet = 4.5;
        double salesCommission = 0.10;
        int stockQuantity = 10;
        int quantity = 5;
        double unitPrice = 7.32;

        //Arrange Client
        String name = "José da Silva";
        String cpfOrCnpj = "123.654.987-87";
        String phone = "(38) 32144-6547";
        String email = "teste@gmail.com";
        String addressField = "Rua A";
        String number = "1010";
        String addressNote = "Teste de obserção";
        String zipCode = "39400000";
        String stateName = "Minas Gerais";
        String stateAbreviation = "MG";
        String cityName = "Ubá";

        //Arrange User
        string Name = "Saulo da Silva";
        string Email = "email@provedor.com";
        string Password = "senhapessoal123";
        DateTime BirthDate = DateTime.Now;
        bool Status = false;

        //Arrange Sale
        DateTime createAt = DateTime.Now;
        double shippingCost = 1.22;
        double discount = 44.09;
        double totalPrice = 124.99;
        String saleNote = "Teste de nota. Teste de nota. Teste de nota.";
        DateTime soldAt = DateTime.Now;

        //Act
        var origin = new DomainEntity.Origin(1, 0);
        var flavor = new DomainEntity.Flavor(1, 2, 3, 4);
        var category = new DomainEntity.Category("Cerveja");
        
        var product = new DomainEntity.Product(
            sku, productName, picture, price, alcoholContet, salesCommission,
            stockQuantity, origin, flavor, category);
        
        var saleItem = new DomainEntity.SaleItem(
            quantity, unitPrice, product);

        var state = new DomainEntity.State(stateName, stateAbreviation);
        var city = new DomainEntity.City(cityName, state);
        var address = new DomainEntity.Address(addressField, number, addressNote, zipCode, state, city);
        var clientType = new DomainEntity.ClientType(1, 0);
        
        var client = new DomainEntity.Client(
            name, cpfOrCnpj, phone, email, address, clientType);

        var saleStatus = new DomainEntity.SaleStatus(1, 1, 0);

        var user = new DomainEntity.User(Name, Email, Password, BirthDate, Status);

        var sale = new DomainEntity.Sale(
            createAt, shippingCost, discount, totalPrice, saleNote, soldAt,
            client, saleItem, saleStatus, user);
        
        //Assert
        product.Should().NotBeNull();
        saleItem.Should().NotBeNull();

        state.Should().NotBeNull();
        city.Should().NotBeNull();
        address.Should().NotBeNull();
        client.Should().NotBeNull();
        sale.Should().NotBeNull();
        sale.CreateAt.Should().Be(createAt);
        sale.ShippingCost.Should().Be(shippingCost);
        sale.Discount.Should().Be(discount);
        sale.TotalPrice.Should().Be(totalPrice);
        sale.Note.Should().Be(saleNote);
        sale.SoldAt.Should().Be(soldAt);
    }
}
