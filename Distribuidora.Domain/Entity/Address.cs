namespace Distribuidora.Domain.Entity;
public class Address
{
    public static Guid Id => Guid.NewGuid();
    public String AddressField { get; set; }
    public String Number { get; set; }
    public String Note { get; set; }
    public String ZipCode { get; set; }
    public State State { get; set; }
    public City City { get; set; }

    public Address(string address, string number, string note, string zipCode, State state, City city)
    {
        AddressField = address;
        Number = number;
        Note = note;
        ZipCode = zipCode;
        State = state;
        City = city;
    }

    public String GetNomeCidadeSiglaEstado()
        => City.Name + " / " + City.State.Abreviation;
}