using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonction_dotNet
{
    public class Class1
    {

        public static void afficherSéparateur()
        {
            Console.WriteLine("----------------------------------");
        }

        public static int additionner(int a, int b)
        {
            return a + b;
        }

        public static bool estPair(int nombre)
        {
            return nombre % 2 == 0;
        }

        public static double CalculerPrixTTC(double prixTTC, double tauxTVA = 0.20)
        {
            return prixTTC * (1 + tauxTVA);
        }

        public static int multiplier(int a, int b)
        {
            return a * b;
        }

        public static int multiplier(int a, int b, int c)
        {
            return a * b * c;
        }

        public static void DireBonjour()
        {
            Console.WriteLine("bonjour!!");
        }

        public void DireBonjourPersonnalise(string prenom)
        {
            Console.WriteLine("bonjour, " + prenom);
        }

        public static void AnalyseNombres(int[] tableau)
        {
            bool EstPair(int x)
            {
                return x % 2 == 0;
            }

            foreach (int nombre in tableau)
            {
                if (EstPair(nombre))
                {
                    Console.WriteLine($"{nombre} est pair");
                }
                else
                {
                    Console.WriteLine($"{nombre} est impair");
                }
            }
        }

        static void AjouterProduit(string nom, int quantite)
        {
            Console.WriteLine("Ajouter produit");
            nom = Console.ReadLine();
            Console.WriteLine("Ajouter quantite produit");
            quantite = int.Parse(Console.ReadLine());
            
            if (nom.Length == 0 || quantite == 0 || quantite < 0)
            {
                Console.WriteLine("nom ou quantite vide ou quantite inférieure à zéro");
            }
            
            
        }
    }
}
