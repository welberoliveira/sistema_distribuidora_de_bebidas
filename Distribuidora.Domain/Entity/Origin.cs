namespace Distribuidora.Domain.Entity;
public class Origin
{
    public static Guid Id = Guid.NewGuid();
    public int National { get; set; }
    public int Foreign { get; set; }

    public Origin(int national, int forein)
    {
        National = national;
        Foreign = forein;
    }
}