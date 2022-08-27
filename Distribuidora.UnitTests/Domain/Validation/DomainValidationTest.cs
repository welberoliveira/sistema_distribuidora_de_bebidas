using Bogus;
using Xunit;
using Distribuidora.Domain.Validation;
using Distribuidora.Domain.Exceptions;
using FluentAssertions;

namespace Distribuidora.UnitTests.Domain.Validation
{
    public class DomainValidationTest
    {
        private Faker Faker { get; set; } = new Faker();

        // não pode ser nulo
        [Fact(DisplayName = nameof(NotNullOk))]
        [Trait("Domain", "DomainValidation - Validation")]
        public void NotNullOk()
        {
            var value = Faker.Commerce.ProductName();
            
            Action action = () => DomainValidation.NotNull(value, "Value");

            action.Should().NotThrow();
        }


        [Fact(DisplayName = nameof(NotNullThrowWhenNull))]
        [Trait("Domain", "DomainValidation - Validation")]
        public void NotNullThrowWhenNull()
        {
            var fieldName = Faker.Commerce.ProductName().Replace(" ", "");
            string? valor = null;

            Action action = () => DomainValidation.NotNull(valor, fieldName);

            action.Should().Throw<EntityValidationException>()
                .WithMessage($"{fieldName} should not be null");
        }


        // não pode ser nulo nem vazio
        [Theory(DisplayName = nameof(NotNullOrEmptyThrowWhenEmpty))]
        [Trait("Domain", "DomainValidation - Validation")]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void NotNullOrEmptyThrowWhenEmpty(string? target)
        {
            var fieldName = Faker.Commerce.ProductName().Replace(" ", "");
            Action action = () => DomainValidation.NotNullOrEmpty(target, fieldName);
            action.Should().Throw<EntityValidationException>()
                .WithMessage($"{fieldName} should not be null or empty");
        }

        [Fact(DisplayName = nameof(NotNullOrEmptyOk))]
        [Trait("Domain", "DomainValidation - Validation")]
        public void NotNullOrEmptyOk()
        {
            var fieldName = Faker.Commerce.ProductName().Replace(" ", "");

            string target = Faker.Commerce.ProductName();
            Action action = () => DomainValidation.NotNullOrEmpty(target, fieldName);

            action.Should().NotThrow();
        }

        // só pode ter 2 caracteres

    }
}
