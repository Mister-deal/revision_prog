using Employe.Interfaces;

namespace Employe.Classes;

public class Entreprise
{
    public List<Itravailleur> effectifs { get; } = new List<Itravailleur>();
    
    public void EffectuerTravail()
    {
        foreach (var effectif in effectifs)
        {
            Console.WriteLine(effectif.travailler());
        }
    }
}