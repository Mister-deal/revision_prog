using Employe.Interfaces;

namespace Employe.Classes;

public class Engineer : Employe, Itravailleur
{
    public string Specialite { get; set; }


    public Engineer(string Nom, decimal Salaire, string specialite) : base(Nom, Salaire)
    {
        Specialite = specialite;
    }

    public string travailler()
    {
        return $"this engineer named {Nom} is working on various projects related to {Specialite}";
    }
    public virtual decimal CalculerPrime(decimal value = 0.15m)
    {
        return this.Salaire * value;
    }
    
}
