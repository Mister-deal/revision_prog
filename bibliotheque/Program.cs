// See https://aka.ms/new-console-template for more information

using bibliotheque.Class;

class Program
{
    static void Main(string[] args)
    {
        Livre livre = new Livre("waiting for godot", "samuel beckett", 1952, false );
        Livre livre2 = new Livre("les misérables", "victor hugo", 1872, false );
        Livre livre3 = new Livre("hadji mourat", "Tolstoï", 1885, true );
        Livre livre4 = new Livre("Oblomov", "ivan gontcharov", 1856, false );

        Livre l = new Livre();
        Livre l2 = new Livre();
        l.title = "waiting for nothing";
        l.author = "samuel becasse";
        l.publicationYear = 2025;
        l.isBorrowed = false;
        l2.isBorrowed = false;
        l2.title = "how to get yourself caught";
        l2.author = "DSK";
        l2.publicationYear = 2011;
        
        livre.Borrowing("i'm borrowing this book for the first time ");
        livre3.Borrowing("book");
        livre.Returning("i'm returning this book ");
        Console.WriteLine(livre);
        Console.WriteLine(livre2);
        Console.WriteLine(livre3);
        Console.WriteLine(livre4);
        Console.WriteLine(l);
        Console.WriteLine(l2);
    }
}





