namespace Distribuidora.Domain.Entity;
public class Origin
{
    public Guid Id = Guid.NewGuid();
    public int National { get; set; }
    public int Forein { get; set; }
}