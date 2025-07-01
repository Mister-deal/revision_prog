using Employe.Interfaces;

namespace Employe.Classes;

public class Manager : Employe, Itravailleur
{
    int EquipeTaille;
    public Manager(string Nom, decimal Salaire, int equipeTaille) : base(Nom, Salaire)
    {
        this.EquipeTaille = equipeTaille;
    }
    
    public virtual decimal CalculerPrime(decimal value = 0.20m)
    {
        return this.Salaire * value + EquipeTaille * 100;
    }

    public string travailler()
    {
        return $"this manager named {Nom} is supervising a team of {EquipeTaille} employees";
    }
    
}