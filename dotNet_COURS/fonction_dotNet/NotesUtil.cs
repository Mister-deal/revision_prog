namespace fonction_dotNet;

public static class NotesUtil
{
    public static double CalculerMoyenne(int totalPoints, int nombreNotes)
    {
        if (nombreNotes == 0)
        {
            return 0.0;
        }
        return (double) totalPoints / nombreNotes;
    }

    public static double CalculerMoyenne(int[] notes)
    {
        if (notes == null || notes.Length == 0)
        {
            return 0.0; // Gère le cas d'un tableau vide ou null
        }

        int totalPoints = 0;
        foreach (int note in notes)
        {
            totalPoints += note;
        }

        // Appel à la première fonction pour éviter de dupliquer le calcul
        double moyenne = CalculerMoyenne(totalPoints, notes.Length);

        // (Optionnel) Fonction locale pour afficher la note maximum
        // (comme demandé dans la partie optionnelle de l'exercice)
        void AfficherMaxMoy()
        {
            if (notes.Length > 0)
            {
                int noteMax = notes.Max(); // Utilise System.Linq pour trouver le maximum
                Console.WriteLine($"Note maximale : {noteMax}");
            }
        }

        AfficherMaxMoy(); // Appel de la fonction locale

        return moyenne;
    }

}