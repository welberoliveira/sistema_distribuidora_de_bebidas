using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Product;
public class ProductTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Product")]
    public void Instaciate()
    {
        //Arrange
        String sku = "Lata";
        String name = "Bhrama";
        String picture = "as65df4a6sd54f6asd54fa6sd54f";
        double price = 5.25;
        double alcoholContet = 4.5;
        double salesCommission = 0.10;
        int stockQuantity = 10;

        //Act
        var origin = new DomainEntity.Origin(1,0);
        var flavor = new DomainEntity.Flavor(1,2,3,4);
        var category = new DomainEntity.Category("Cerveja");
        var product = new DomainEntity.Product(
            sku, name, picture, price, alcoholContet, salesCommission,
            stockQuantity, origin, flavor, category);

        //Assert
        product.Should().NotBeNull();
        product.Sku.Should().Be(sku);
        product.Name.Should().Be(name);
        product.Picture.Should().Be(picture);
        product.AlcoholContet.Should().Be(alcoholContet);
        product.Price.Should().Be(price);
        product.SalesCommission.Should().Be(salesCommission);
        product.StockQuantity.Should().Be(stockQuantity);
    }
}
