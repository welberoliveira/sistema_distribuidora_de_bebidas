namespace Distribuidora.Domain.Entity;
public class Flavor
{
    public static Guid Id = Guid.NewGuid();
    public int Sweetened { get; set; }
    public int Bitter { get; set; }
    public int Fruity { get; set; }
    public int Smooth { get; set; }
    
    public Flavor(int sweetened, int bitter, int fruity, int smooth)
    {
        this.Sweetened = sweetened;
        this.Bitter = bitter;
        this.Fruity = fruity;
        this.Smooth = smooth;
    }
}
