using Employe.Interfaces;

namespace Employe.Classes;

public class Entreprise
{
    List<Itravailleur> effectifs = new List<Itravailleur>();

    public List<Itravailleur> Effectifs;
    

    public void EffectuerTravail()
    {
        foreach (List<Itravailleur> effectif in Effectifs)
        {
            
        }
    }
}