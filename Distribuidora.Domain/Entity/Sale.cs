namespace Distribuidora.Domain.Entity;
public class Sale
{
    public DateTime CreateAt { get; set; }
    public double ShippingCost { get; set; }
    public double Discount { get; set; }
    public double TotalPrice { get; set; }
    public String? Note { get; set; }
    public DateTime SoldAt { get; set; }
    public Client Client { get; set; }
    public SaleItem SaleItem { get; set; }
    public SaleStatus SaleStatus { get; set; }
    public User User { get; set; }

    public Sale(
        DateTime createAt, double shippingCost, double discount, 
        double totalPrice, string? note, DateTime soldAt, Client client, 
        SaleItem saleItem, SaleStatus saleStatus, User user
    ) 
    {
        CreateAt = createAt;
        ShippingCost = shippingCost;
        Discount = discount;
        TotalPrice = totalPrice;
        Note = note;
        SoldAt = soldAt;
        Client = client;
        SaleItem = saleItem;
        SaleStatus = saleStatus;
        User = user;
    }
}