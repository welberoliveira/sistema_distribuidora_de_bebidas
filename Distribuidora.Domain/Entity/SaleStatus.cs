namespace Distribuidora.Domain.Entity;
public class SaleStatus
{
    public static Guid Id = Guid.NewGuid();
    public double Budget { get; set; }
    public int Issued { get; set; }
    public int Canceled { get; set; }

    public SaleStatus(double budget, int issued, int canceled)
    {
        Budget = budget;
        Issued = issued;
        Canceled = canceled;
    }
}