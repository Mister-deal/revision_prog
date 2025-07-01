// See https://aka.ms/new-console-template for more information

using Employe.Classes;
using Employe.Interfaces;

    Entreprise Nestle = new Entreprise();

    Manager manager = new Manager("Karl Dieter", 2023.3m, 5);
    Manager manager1 = new Manager("bertrand Bloom", 3000.3m, 20);
    Manager manager2 = new Manager("Hans Gurthing", 2675.2m, 10);
    Engineer engineer = new Engineer("Cédric Dubois", 1900.3m, "Data Engineering");
    Engineer engineer1 = new Engineer("Didier Dubois", 1950.3m, "Web Programming");

    Nestle.effectifs.Add(engineer);
    Nestle.effectifs.Add(engineer1);
    Nestle.effectifs.Add(manager);
    Nestle.effectifs.Add(manager1);
    Nestle.effectifs.Add(manager2);

    Console.WriteLine("ingénieurs: ");
    foreach (var t in Nestle.effectifs)
    {
        if (t is Engineer e)
        {
            Console.WriteLine($"- {e.Nom} (Spécialité : {e.Specialite})");
        }
    }
    Nestle.EffectuerTravail();
    

    // 2. Affichage des primes
    Console.WriteLine("\nPrimes :");
    foreach (var travailleur in Nestle.effectifs)
    {
        if (travailleur is Employe.Classes.Employe e)
        {
            Console.WriteLine($"{e.Nom} : {e.CalculerPrime()} dollars");
        }
    }

    // 3. Nombre total d’employés
    Console.WriteLine();
    Employe.Classes.Employe.AfficherNombreEmployes();

