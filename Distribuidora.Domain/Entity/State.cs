using System.ComponentModel.DataAnnotations;

namespace Distribuidora.Domain.Entity;
public class State
{
    public static Guid Codigo => Guid.NewGuid();

    [Display(Name = "Nome do Estado")]
    [StringLength(50, MinimumLength = 3)]
    public String? Name { get; set; }

    [Display(Name = "Abreviação")]
    [StringLength(2)]
    public String? Abreviation { get; set; }

    public State(string name, string abreviation)
    {
        Name = name;
        Abreviation = abreviation;
    }

    public ICollection<City> Citys { get; set; }


    /*
    É necessário entender para que essa função foi criada, por isso mantive comentada porque 
    apesar de eu não ter entendido o que ela faz, isso pode ser útil no futuro
    */
    /*
     private static long serialVersionUID = 1L;
     public int HashCode() => Codigo.GetHashCode();
     public bool equals(Object obj)
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