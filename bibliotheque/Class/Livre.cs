namespace bibliotheque.Class;

public class Livre
{
    public string title {get; set;}
    public string author {get; set;}
    public int publicationYear {get; set;}
    public bool isBorrowed {get; set;}
    

    public Livre(string title, string author, int publicationYear, bool isBorrowed)
    {
        this.title = title;
        this.author = author;
        this.publicationYear = publicationYear;
        this.isBorrowed = isBorrowed;
    }

    public Livre()
    {
    }

    public void Borrowing(string description)
    {
        if (this.isBorrowed != true)
        {
            Console.WriteLine($"borrowing {this.title}, {description}");
        }
        else
        {
            isBorrowed = true;
            Console.WriteLine($"{description} is already borrowed");
        }
        
        
        
    }

    public void Returning(string description)
    {
        isBorrowed = false;
        Console.WriteLine($"this book is now available, {description}");
    }

    public override string ToString()
    {
        return "Livre: " + this.title + " " + this.author + " " + this.publicationYear;
    }
    
    
}