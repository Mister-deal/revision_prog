using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace fonction_dotNet;

public class GestionnaireStock
{
    static Dictionary<string, int> stock =  new Dictionary<string, int>();
    public static void AjouterProduit(string nom, int quantite)
    {
        if (stock.ContainsKey(nom))
        {
            stock[nom] += quantite;
        }
        else
        {
            stock[nom] = quantite;
        }
        Console.WriteLine($"produit ajouté: {nom} ({quantite}), total: {stock[nom]}");
            
    }

    public static void RetirerProduit(string nom, int quantite)
    {
        if (stock.ContainsKey(nom))
        {
            stock[nom] -= quantite;
            Console.WriteLine($"produit retiré: {nom} ({quantite}), total: {stock[nom]}");
        }
        else
        {
            Console.WriteLine($"le produit {nom} n'existe pas dans le stock.");
        }
    }

    public static void AfficherStock()
    {
        Console.WriteLine("--- Gestionnaire de stock ---");
        Console.WriteLine("--- Stock actuel ---");
        foreach (var nom in stock)
        {
            Console.WriteLine($"{nom.Key}: {nom.Value}");
        }
    }
}