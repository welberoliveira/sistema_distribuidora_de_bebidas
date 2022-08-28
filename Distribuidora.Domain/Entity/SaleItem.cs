namespace Distribuidora.Domain.Entity;
public class SaleItem
{
    public static Guid Id = Guid.NewGuid();
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public Product Product { get; set; }

    public SaleItem(int quantity, double unitPrice, Product product)
    {
        this.Quantity = quantity;
        this.UnitPrice = unitPrice;
        Product = product;
    }
}