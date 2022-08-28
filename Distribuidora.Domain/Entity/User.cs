using Distribuidora.Domain.Validation;

namespace Distribuidora.Domain.Entity
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public bool Status { get; protected set; }

        public User(string name, string email, string password, DateTime birthDate, bool status = true)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Status = status;
            Validate();
        }

        public void Activate()
        {
            Status = true;
            Validate();
        }

        public void Deactivate()
        {
            Status = false;
            Validate();
        }

        public void Update(string name, string email)
        {
            Name = name;
            Email = email;
            Validate();
        }

        public void PasswordUpdate(string password)
        {
            Password = password;
            Validate();
        }
        private void Validate()
        {
            // Dados mínimos do cliente que não podem estar vazios
            DomainValidation.NotNullOrEmpty(Name, nameof(Name));
            DomainValidation.NotNullOrEmpty(Email, nameof(Email));
            DomainValidation.NotNullOrEmpty(Password, nameof(Password));
        }
    }
}
