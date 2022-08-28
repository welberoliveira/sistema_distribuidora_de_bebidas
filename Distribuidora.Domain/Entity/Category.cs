namespace Distribuidora.Domain.Entity;
public class Category
{
    public Guid Id => Guid.NewGuid();
    public String Name { get; set; }

    public Category(string name)
        => Name = name;
}
