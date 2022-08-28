using DomainEntity = Distribuidora.Domain.Entity;
using Xunit;
using FluentAssertions;
using Bogus;
using Distribuidora.Domain.Exceptions;

namespace Distribuidora.UnitTests.Domain.Entity.User
{
    public class UserTest
    {
        private Faker faker { get; set; } = new Faker();

        [Fact(DisplayName = nameof(Instaciate))]
        [Trait("Domain", "User")]
        public void Instaciate()
        {
            //Arrange
            string Name = faker.Name.FullName();
            string Email = faker.Person.Email;
            string Password = faker.Person.UserName;
            DateTime BirthDate = DateTime.Now;
            bool Status = false;

            //Act
            var user = new DomainEntity.User(Name, Email, Password, BirthDate, Status);

            //Assert
            user.Should().NotBeNull();
            user.Name.Should().Be(Name);
            user.Email.Should().Be(Email);
            user.Password.Should().Be(Password);
            user.BirthDate.Should().Be(BirthDate);
            user.Status.Should().Be(Status);
        }

        [Theory(DisplayName = nameof(InstantiateErrorWhenNameIsEmpty))]
        [Trait("Domain", "User")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void InstantiateErrorWhenNameIsEmpty(string? name)
        {
            DateTime birthDate = DateTime.Now;

            Action action = () => new DomainEntity.User(name!, "Valid Email", "Valid Password", birthDate);

            action.Should().Throw<EntityValidationException>()
                .WithMessage($"Name should not be null or empty");
        }

        [Theory(DisplayName = nameof(InstantiateErrorWhenEmailIsEmpty))]
        [Trait("Domain", "User")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void InstantiateErrorWhenEmailIsEmpty(string? email)
        {
            DateTime birthDate = DateTime.Now;

            Action action = () => new DomainEntity.User("Valid Name", email!, "Valid Password", birthDate);

            action.Should().Throw<EntityValidationException>()
                .WithMessage($"Email should not be null or empty");
        }

        [Theory(DisplayName = nameof(InstantiateErrorWhenPasswordIsEmpty))]
        [Trait("Domain", "User")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void InstantiateErrorWhenPasswordIsEmpty(string? password)
        {
            DateTime birthDate = DateTime.Now;

            Action action = () => new DomainEntity.User("Valid Name", "Valid Email", password!, birthDate);

            action.Should().Throw<EntityValidationException>()
                .WithMessage($"Password should not be null or empty");
        }

        [Fact(DisplayName = nameof(Activate))]
        [Trait("Domain", "User")]
        public void Activate()
        {
            DateTime birthDate = DateTime.Now;
            var user = new DomainEntity.User("Valid Name", "Valid Email", "Valid Password", birthDate);
            
            user.Activate();

            user.Status.Should().BeTrue();
        }

        [Fact(DisplayName = nameof(Deactivate))]
        [Trait("Domain", "User")]
        public void Deactivate()
        {
            DateTime birthDate = DateTime.Now;
            var user = new DomainEntity.User("Valid Name", "Valid Email", "Valid Password", birthDate);

            user.Deactivate();

            user.Status.Should().BeFalse();
        }

        [Fact(DisplayName = nameof(Update))]
        [Trait("Domain", "User")]
        public void Update()
        {
            DateTime birthDate = DateTime.Now;
            var user = new DomainEntity.User("Valid Name", "Valid Email", "Valid Password", birthDate);

            user.Update("New Name", "New Email");

            user.Name.Should().Be("New Name");
            user.Email.Should().Be("New Email");
        }

        [Fact(DisplayName = nameof(UpdateOnlyPassword))]
        [Trait("Domain", "User")]
        public void UpdateOnlyPassword()
        {
            DateTime birthDate = DateTime.Now;
            var user = new DomainEntity.User("Valid Name", "Valid Email", "Valid Password", birthDate);

            user.PasswordUpdate("New Password");

            user.Password.Should().Be("New Password");
            user.Name.Should().Be("Valid Name");
            user.Email.Should().Be("Valid Email");
        }

        [Theory(DisplayName = nameof(UpdateErrorWhenNameIsEmpty))]
        [Trait("Domain", "User")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void UpdateErrorWhenNameIsEmpty(string? name)
        {
            DateTime birthDate = DateTime.Now;
            var user = new DomainEntity.User("Valid Name", "Valid Email", "Valid Password", birthDate);

            Action action = () => user.Update(name!, "Valid Email");

            action.Should().Throw<EntityValidationException>()
                .WithMessage("Name should not be null or empty");
        }

        [Theory(DisplayName = nameof(UpdateErrorWhenEmailIsEmpty))]
        [Trait("Domain", "User")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void UpdateErrorWhenEmailIsEmpty(string? email)
        {
            DateTime birthDate = DateTime.Now;
            var user = new DomainEntity.User("Valid Name", "Valid Email", "Valid Password", birthDate);

            Action action = () => user.Update("Valid Name", email!);

            action.Should().Throw<EntityValidationException>()
                .WithMessage("Email should not be null or empty");
        }
    }
}
