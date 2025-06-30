// See https://aka.ms/new-console-template for more information

using Calculatrice;

//initialisation classe calculatrice
calculatrice calc = new calculatrice();
//variable bool pour voir si l'application tourne ou non tant qu'elle est en true
bool app = true;
string? choice;
//boucle while jusqu'à que l'application passe en false
while (app)
{
    Console.WriteLine("please, enter your name: ");
    //creation nom utilisateur
    
    string nameUser = Console.ReadLine();
    //appel de la fonction helloUser, fonction n'étant pas statique
    
    calc.helloUser(nameUser);
    
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"=== calculator in C# === user: {nameUser}");
    Console.WriteLine();
    Console.WriteLine("----------- 1= addition: --------------");
    Console.WriteLine();
    Console.WriteLine("----------- 2= subtraction: ----------- ");
    Console.WriteLine();
    Console.WriteLine("----------- 3= multiplication: ----------- ");
    Console.WriteLine();
    Console.WriteLine("----------- 4= division: ----------- ");
    Console.WriteLine();
    Console.WriteLine("----------- 5= power: ----------- ");
    Console.WriteLine();
    Console.WriteLine("----------- 6= percentage: ----------- ");
    Console.WriteLine();
    Console.WriteLine("----------- 7= square root: ----------- ");
    Console.WriteLine();
    Console.WriteLine("----------- 8= exit ----------- ");
    Console.WriteLine();
    Console.WriteLine();
    
    Console.Write($"please, enter your choice, {nameUser}: ");
    Console.WriteLine();
    
    //variable string pour définir choix
    choice = Console.ReadLine();
    
    //variables double afin d'y introduire valeurs, et résultat
    double firstChoice =0 , secondChoice = 0, result = 0;
    
    //permet de vérifier si les valeurs sont différentes de "7" et de "8"; si oui, alors les deux variables peuvent être initialisées
    if(choice != "7" && choice !="8")
    {
        Console.WriteLine("enter the first value");
        firstChoice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the second value");
        secondChoice = Convert.ToDouble(Console.ReadLine());
    }
    
    //si la valeur "7" est appelée, alors une seule valeur est entrée
    else if (choice == "7")
    {
        Console.WriteLine("enter a number: ");
        firstChoice = Convert.ToDouble(Console.ReadLine());
    }

    // try / catch afin de checker si un comportement non désiré se déclenche, si tout fonctionne, le try fonctionne et le switch se déclenche.
    try
    {
        //switch du string choix afin de savoir quel choix l'utilisateur a fait
        switch (choice)
        {
            case "1":
                calc.Add(firstChoice, secondChoice);
                Console.WriteLine();
                break;
            case "2":
                calc.Substract(firstChoice, secondChoice);
                Console.WriteLine();
                break;
            case "3":
                calc.Multiply(firstChoice, secondChoice);
                Console.WriteLine();
                break;
            case "4":
                calc.Divide(firstChoice, secondChoice);
                Console.WriteLine();
                break;
            case "5":
                calc.Power(firstChoice, secondChoice);
                Console.WriteLine();
                break;
            case "6":
                calc.percentage(firstChoice, secondChoice);
                Console.WriteLine();
                break;
            case "7":
                calc.SquareRoot(firstChoice);
                Console.WriteLine();
                break;
            case "8":
                Console.WriteLine("thank you very much. see you next time.");
                app = false;
                break;
            default:
                Console.WriteLine("invalid input.");
                app = false;
                break;
        }
    }
    catch (Exception e)
    //si le try ne fonctionne pas car un comportement sortant du cadre des comportements désirés se déclare, le catch permet de récupérer l'exception e
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("press any key to exit.");
    Console.ReadKey();
    
}