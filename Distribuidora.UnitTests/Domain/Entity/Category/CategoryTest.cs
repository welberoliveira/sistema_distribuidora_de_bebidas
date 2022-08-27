using Xunit;
using DomainEntity = Distribuidora.Domain.Entity;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Entity.Category;
public class CategoryTest
{
    [Fact(DisplayName = nameof(Instaciate))]
    [Trait("Domain", "Category")]
    public void Instaciate()
    {
        //Arrange
        String Name = "Cerveja";

        //Act
        var Category = new DomainEntity.Category(Name);

        //Assert
        Category.Should().NotBeNull();
        Category.Name.Should().Be(Name);
    }
}
