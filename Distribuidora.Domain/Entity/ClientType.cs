namespace Distribuidora.Domain.Entity;
public class ClientType
{
    public ClientType(int normalPerson, int legalPerson)
    {
        NormalPerson = normalPerson;
        LegalPerson = legalPerson;
    }

    public int NormalPerson { get; set; }
    public int LegalPerson { get; set; }
}
