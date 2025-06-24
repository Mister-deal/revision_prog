namespace openClassRoom_csharp;

public class Livre
{
    public string titre { get; set; }
    public string description { get; set; }
    public string auteur { get; set; }
    public int nombreDePages { get; set; }
    public string editeur { get; set; }

    public Livre(string titre, string description, string auteur, int nombreDePages, string editeur)
    {
        this.titre = titre;
        this.description = description;
        this.auteur = auteur;
        this.nombreDePages = nombreDePages;
        this.editeur = editeur;
    }

    public override string ToString()
    {
        return $@"--- Livre ---
Titre       : {titre}
Description : {description}
Auteur      : {auteur}
Pages       : {nombreDePages}
Éditeur     : {editeur}";
    }

}