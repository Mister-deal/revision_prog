namespace Employe.Classes;

public abstract class Employe
{
    public string Nom { get; }

    protected decimal Salaire;
    

    static int NombreTotalEmployes;

    public Employe(string Nom, decimal Salaire)
    {
        if (Salaire < 0)
        {
            throw new ArgumentException("your wage cannot be negative");
        }
        this.Nom = Nom;
        this.Salaire = Salaire;
        NombreTotalEmployes++;
    }

    public virtual decimal CalculerPrime(decimal value = 0.10m)
    {
        return this.Salaire * value;
    }

    public static void AfficherNombreEmployes()
    {
        Console.WriteLine($"nombre: {NombreTotalEmployes}");
    }


}