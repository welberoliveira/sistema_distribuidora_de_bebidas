namespace Distribuidora.Domain.Entity;
public class Product
{
    public static Guid Id = Guid.NewGuid();
    public String Sku {get;set;}
    public String Name { get; set; }
    public String Picture { get; set; }
    public double Price { get; set; }
    public double AlcoholContet { get; set; }
    public double SalesCommission { get; set; }
    public int StockQuantity { get; set; }
    public Origin Origin { get; set; }
    public Flavor Flavor { get; set; }
    public Category Category { get; set; }

    public Product(string sku, string name, string picture, double price, double alcoholContet, 
        double salesCommission, int stockQuantity, Origin origin, Flavor flavor, Category category)
    {
        Sku = sku;
        Name = name;
        Picture = picture;
        Price = price;
        AlcoholContet = alcoholContet;
        SalesCommission = salesCommission;
        StockQuantity = stockQuantity;
        Origin = origin;
        Flavor = flavor;
        Category = category;
    }
}
