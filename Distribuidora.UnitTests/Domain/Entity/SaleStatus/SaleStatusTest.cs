using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.SaleStatus;
public class SaleStatusTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "SaleStatus")]
    public void Instaciate()
    {
        //Arrange
        double budget = 1000.10;
        int issued = 1;
        int canceled = 0;

        //Act
        var saleStatus = new DomainEntity.SaleStatus(budget, issued, canceled);

        //Assert
        saleStatus.Should().NotBeNull();
        saleStatus.Budget.Should().Be(budget);
        saleStatus.Issued.Should().Be(issued);
        saleStatus.Canceled.Should().Be(canceled);
    }
}
