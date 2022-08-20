namespace Distribuidora.Domain.Entity;
public class City
{
    public Guid Codigo => Guid.NewGuid();
    public String Name { get; set; }
    public State State { get; set; }

    public City(string name, State state)
    {
        Name = name;
        State = state;
    }
}