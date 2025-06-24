// See https://aka.ms/new-console-template for more information

using openClassRoom_csharp;

int prime = 500;
Console.WriteLine(prime);

int epargne = 3000;
epargne += prime;
Console.WriteLine(epargne);

int jourDeDepart = 3;
int jourDansSemaine = 7;
jourDansSemaine += jourDeDepart;
Console.WriteLine(jourDansSemaine);

int a = 10;
double b = 4;
double c = a / b;
Console.WriteLine(c);

int numerateur = 10;
int denominateur = 4;

int reponse = numerateur / denominateur;
Console.WriteLine(numerateur + " / " + denominateur + " = " + reponse);

string animals = "j'aime les chiens et chats";
Console.WriteLine(animals);

Livre livre = new Livre("dickin's", "livre concernant la joie", "loyd dickens", 250, "OC");
Console.WriteLine(livre.ToString());

string[] couleurs = new string[] { "bleu", "vert", "rouge", "orange", "violet" };
couleurs[1] = "emeraude";
Console.WriteLine(couleurs[1]);

foreach (string couleur in couleurs)
{
    Console.WriteLine(couleur);
}

IList<string> invites = new List<string>();
invites.Add("pierre");
invites.Add("marc");
invites.Add("didier");
Console.WriteLine(invites.Count);
invites.Insert(1, "jean");
Console.WriteLine("-------------");
//Console.WriteLine(invites[1]);
invites.Remove("pierre");
foreach (string invite in invites)
{
    Console.WriteLine(invite);
}


ISet<string> ingredients = new HashSet<string>();
ingredients.Add("sugar");
ingredients.Add("chocolate");
ingredients.Add("butter");
ingredients.Add("vanilla");

ingredients.Add("cheese");

ingredients.Remove("vanilla");

Console.WriteLine(ingredients.Count);
Console.WriteLine("voici la liste des ingredients : ");
foreach (string ingredient in ingredients)
{
    Console.WriteLine(ingredient);
}

