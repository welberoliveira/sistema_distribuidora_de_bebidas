namespace Distribuidora.Domain.Entity;
public class State
{
    private static long serialVersionUID = 1L;

    public Guid Id => Guid.NewGuid();
    public String Name { get; set; }
    public String Abreviation { get; set; }

    public State(string name, string abreviation)
    {
        Name = name;
        Abreviation = abreviation;
    }

    public int HashCode() => Id.GetHashCode();
    
    /*
    É necessário entender para que essa função foi criada, por isso mantive comentada porque 
    apesar de eu não ter entendido o que ela faz, isso pode ser útil no futuro
    */
    /*public bool equals(Object obj)
    {
        /*if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (getClass() != obj.getClass())
            return false;
        Estado other = (Estado)obj;
        if (Codigo == null)
        {
            if (other.codigo != null)
                return false;
        }
        else if (!Codigo.equals(other.codigo))
            return false;
        return true;
    }*/
}