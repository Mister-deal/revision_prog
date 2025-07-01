namespace Employe.Classes;

public abstract class Employe
{
    public string Nom { get; }

    protected decimal Salaire;

    static int NombreTotalEmployes;

    public Employe(string Nom, decimal Salaire)
    {
        this.Nom = Nom;
        this.Salaire = Salaire;
        NombreTotalEmployes++;
    }

    public virtual decimal CalculerPrime(decimal value = 0.10m)
    {
        return this.Salaire * value;
    }

    public static int AfficherNombreEmployes()
    {
        return NombreTotalEmployes;
    }


}