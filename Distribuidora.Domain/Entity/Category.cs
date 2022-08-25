namespace Distribuidora.Domain.Entity;
internal class Category
{
    public Guid Id => Guid.NewGuid();
    public String Name { get; set; }

    public Category(string name)
        => Name = name;
}
