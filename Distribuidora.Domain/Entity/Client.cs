namespace Distribuidora.Domain.Entity;
public class Client
{
    public static Guid Id = Guid.NewGuid();
    public string Name { get; set; }
    public string CpfOrCnpj { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Address address { get; set; }
    public ClientType clientType { get; set; }

    public Client(string name, string cpfOrCnpj, string phone, string email, Address address, ClientType clientType)
    {
        Name = name;
        CpfOrCnpj = cpfOrCnpj;
        Phone = phone;
        Email = email;
        this.address = address;
        this.clientType = clientType;
    }
}
