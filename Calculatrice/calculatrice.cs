namespace Calculatrice;

public class calculatrice
{
    //fonction void, sans notion de return, définie en public pour la visibilité; elle renvoie une valeur chaine de caractères.
    public void helloUser(string user)
    {
        Console.WriteLine($"hello {user}");
    }
    //fonction permettant une addition simple entre deux variables double
    public void Add(double a, double b)
    {
        double result = a + b;
        Console.WriteLine($"{a} + {b} = {result}");
    }
    //fonction permettant une soustraction simple entre deux variables double
    public void Substract(double a, double b)
    {
        if (a < 0 || b < 0)
        {
            Console.WriteLine("do not use negative values");
        }
        
        double result = a - b;
        Console.WriteLine($"{a} - {b} = {result}");
    }
    //fonction permettant une division simple entre deux variables double
    public void Divide(double a, double b)
    {
        double result;
        if (b == 0)
        {
            throw new DivideByZeroException("it doesn't support division by zero");
        }
        result = a / b;
        Console.WriteLine($"{a} / {b} = {result}");
    }
    //fonction permettant une multiplication simple entre deux variables double
    public void Multiply(double a, double b)
    {
        double result = a * b;
        Console.WriteLine($"{a} * {b} = {result}");
    }

    //fonction permettant de calculer le pourcentage de deux valeurs données
    public void percentage(double a, double b)
    {
        double result = (a * b) / 100;
        Console.WriteLine($"{a}% of {b} = {result}");
    }

    //fonction pour connaitre la puissance d'une valeur
    public void Power(double a, double b)
    {
        double result = Math.Pow(a, b);
        Console.WriteLine($"{result}");
    }
    //fonction pour calculer la racine carrée d'une valeur
    public void SquareRoot(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("the number cannot be negative");
        }
        double result = Math.Sqrt(a);
        Console.WriteLine($"{result}");
    }

    
    
}