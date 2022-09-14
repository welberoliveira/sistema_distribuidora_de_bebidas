namespace Distribuidora.Domain.Entity;
public class Permission
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Permission(string name)
        => Name = name;
}