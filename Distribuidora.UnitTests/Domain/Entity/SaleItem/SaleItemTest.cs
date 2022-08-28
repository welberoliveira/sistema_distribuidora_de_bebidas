using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.SaleItem;
public class SaleItemTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "SaleItem")]
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
        int quantity = 5;
        double unitPrice = 7.32;

        //Act
        var origin = new DomainEntity.Origin(1, 0);
        var flavor = new DomainEntity.Flavor(1, 2, 3, 4);
        var category = new DomainEntity.Category("Cerveja");
        var product = new DomainEntity.Product(
            sku, name, picture, price, alcoholContet, salesCommission,
            stockQuantity, origin, flavor, category);
        var saleItem = new DomainEntity.SaleItem(quantity, unitPrice, product);

        //Assert
        product.Should().NotBeNull();
        saleItem.Should().NotBeNull();
        saleItem.Quantity.Should().Be(quantity);
        saleItem.UnitPrice.Should().Be(unitPrice);
    }
}
