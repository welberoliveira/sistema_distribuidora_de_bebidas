
namespace Distribuidora.Domain.Entity;
public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Permission Permission { get; set; }

    public Group(string name, Permission permission)
    {
        Name = name;
        Permission = permission;
    }
}
