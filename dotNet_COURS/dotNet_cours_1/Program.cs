// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using dotNet_cours_1;

Console.WriteLine("Hello, World!");

/*
int number;

Console.WriteLine("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());

if (number > 10)
{
    Console.WriteLine("The number is greater than 10.");
}
else if (number < 10)
{
    Console.WriteLine("The number is less than 10.");
}
else
{
    Console.WriteLine("The number is equal to 10.");
}
;

int number1;

Console.WriteLine("Enter another number: ");
number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (number1 < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is null.");
};

int age;

Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
;
/*
string Test(string input)
{

    Console.WriteLine("enter some text: ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        return "Input is null or empty.";
    }
    else
    {
        return "Input is valid: " + input;
    }
};

*/

/*
int number2;
Console.WriteLine("Enter a number to check if it's even or odd: ");
number2 = Convert.ToInt32(Console.ReadLine());

if (number2 % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
};

int number3;
int number4;

Console.WriteLine("Enter the first number: ");
number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
number4 = Convert.ToInt32(Console.ReadLine());

if (number3 > number4)
{
    Console.WriteLine("The first number is greater than the second number.");
}
else if (number3 < number4)
{
    Console.WriteLine("The second number is greater than the first number.");
}
else
{
    Console.WriteLine("Both numbers are equal.");
};


int number5;
Console.WriteLine("Enter a number to check if it's divisible by 3 or 5: ");

number5 = Convert.ToInt32(Console.ReadLine());

if (number5 % 3 == 0 || number5 % 5 == 0)
{
    Console.WriteLine("The number is divisible by 3 or 5.");
}
else
{
    Console.WriteLine("The number is not divisible by 3 or 5.");
};


const string password;
Console.WriteLine("Enter your password: ");
password = Console.ReadLine();

if (password != "admin")
{
    Console.WriteLine("you didn't manage to log in");
}
else
{
    Console.WriteLine("you managed to log in");
};

string[] vowels = { "a", "e", "i", "o", "u" };
Console.WriteLine("Enter a letter to check if it's a vowel: ");
string letter = Console.ReadLine().ToLower();

if (letter.Length == 1)
{
    if (Array.Exists(vowels, v => v == letter))
    {
        Console.WriteLine($"{letter}" + " is a voyel");
    }

    else
    {
        Console.WriteLine($"{letter}" + " is not a voyel");
    }
}
else
{
    Console.WriteLine("Please enter a single letter.");
};

*/
/*
int number6;
Console.WriteLine("Enter a number to check if it is between 10 and 20 or not : ");

number6 = Convert.ToInt32(Console.ReadLine());

if (number6 >= 10 && number6 <= 20)
{
    Console.WriteLine($"{number6}"  + " The number is between 10 and 20.");
}
else
{
    Console.WriteLine($"{number6}" + " The number is not between 10 and 20.");
}

int age1;
Console.WriteLine("Enter your age to check if you are either a child, a teenager, or an adult: ");

age1 = Convert.ToInt32(Console.ReadLine());

if (age1 < 12)
{
    Console.WriteLine("You are a child.");
}
else if (age1 >= 12 && age1 < 18)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are an adult.");
}

int date;
Console.WriteLine("Enter a date to check if it is a leap year or not: ");
date = Convert.ToInt32(Console.ReadLine());

if (date % 4 == 0 || date % 400 == 0)
{
    Console.WriteLine($"{date}" + " is a leap year.");
}
else
{
        Console.WriteLine($"{date}" + " is not a leap year.");
}

int number7;
Console.WriteLine("Enter a number and check if it is both divisible by 5 and a positive number or not");
number7 = Convert.ToInt32(Console.ReadLine());

if (number7 > 0)
{
    if (number7 % 5 == 0)
    {
        Console.WriteLine($"{number7}" + " is a positive number and divisible by 5.");
    }
    else
    {
        Console.WriteLine($"{number7}" + " is a positive number but not divisible by 5.");
    }
}
else
{
    Console.WriteLine($"{number7}" + " is not a positive number.");
};

string input;
Console.WriteLine("Enter a string to check if it has the letter 'a' or not: ");
input = Console.ReadLine().ToLower();
if (input.Contains("a"))
{
    Console.WriteLine("The string contains the letter 'a'.");
}
else
{
    Console.WriteLine("The string does not contain the letter 'a'.");
}

int number8;
Console.WriteLine("Enter a number to check if it is a multiple of 2 or 3 but not by 9: ");
number8 = Convert.ToInt32(Console.ReadLine());

if ((number8 % 2 == 0 || number8 % 3 == 0) && number8 % 9 != 0)
{
    Console.WriteLine($"{number8}" + " is a multiple of 2 or 3 but not by 9.");
}
else
{
    Console.WriteLine($"{number8}" + " is not a multiple of 2 or 3 or it is a multiple of 9.");
}
const string username = "user";
const string password = "password";

Console.WriteLine("Enter your username: ");
string inputUsername = Console.ReadLine();
Console.WriteLine("Enter your password: ");
string inputPassword = Console.ReadLine();

if(inputUsername != username || inputPassword != password)
{
    Console.WriteLine("Invalid username or password.");
}
else
{
    Console.WriteLine("Login successful.");
}

int note;
Console.WriteLine("Enter a note (0-100), if the grade is between 100 and 85, you will be congratulated: ");
note = Convert.ToInt32(Console.ReadLine());
if(note < 0 || note > 100)
{
    Console.WriteLine("Invalid note. Please enter a number between 0 and 100.");
}if (note >= 85 && note <= 100)
{
    Console.WriteLine("Congratulations! You have an excellent note.");
}
else if (note < 85 && note >= 50)
{
    Console.WriteLine("you passed! but you can still do better than that.");
}
else
{
    Console.WriteLine("Unfortunately, you failed. Better luck next time.");
}
/*
string palindrome;
Console.WriteLine("Enter a word to check if it is a palindrome: ");
palindrome = Console.ReadLine().ToLower();
bool isPalindrome;

for (int i = 0; i < palindrome.Length /2; i++) { 
if (palindrome[i]! = palindrome[palindrome.Length - 1 - i])
    {
               Console.WriteLine($"{palindrome}" + " is not a palindrome.");
        return;
    }
    else
    {
               Console.WriteLine($"{palindrome}" + " is a palindrome.");
    }
}
*/
/*
int number9;
Console.WriteLine("Enter a number to check if it is either a positive number, even and superior to 100: ");
number9 = Convert.ToInt32(Console.ReadLine());
if(number9 > 0)
{
    if(number9 % 2 == 0 && number9 > 100)
    {
        Console.WriteLine($"{number9}" + " is a positive, even number and superior to 100.");
    }
    else
    {
        Console.WriteLine($"{number9}" + " is a positive number but not even or not superior to 100.");
    }
}
else
{
    Console.WriteLine ("the number is not positive.");
}

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.Write("");
    }
}

int inputNumber;
Console.WriteLine("Enter a number to display the multiplication table of this number between 1 and 10: ");
inputNumber = Convert.ToInt32(Console.ReadLine());
if(inputNumber < 0 || inputNumber > 10)
{
    Console.WriteLine("Please enter a number between 1 and 10.");
}
else
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{inputNumber} x {i} = {inputNumber * i}");
    }
}

string inputString;
Console.WriteLine("Enter a string to display its characters one by one: ");
inputString = Console.ReadLine();
if (string.IsNullOrEmpty(inputString))
{
    Console.WriteLine("Veuillez écrire quelque chose");
}
else
{
    for (int i = 0; i < inputString.Length; i++)
    {
        Console.WriteLine(inputString[i]);
    }
}

HashSet<string> validColors;
validColors = new HashSet<string> { "red", "green", "blue", "yellow", "purple" };

for(int i = 0; i < validColors.Count; i++)
{
    Console.WriteLine("Objects inside the array: " + validColors.ElementAt(i));
}

for(int i = 0; i < 100; i++)
{
    if(i % 10 == 0)
    {
        Console.WriteLine(i);
    }else
    {
        Console.Write("");
    }
}

HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
for (int i = 0; i < names.Count; i++)
{
   Console.WriteLine("Names in the set: " + names.ElementAt(i));
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

int result = 0;

for (int i = 1; i <= 50; i++)
{
    result += i;
    Console.WriteLine($"The sum of result is {result}");
}

/*
 * const string alphabet = "abcdefghijklmnopqrstuvwxyz";

for (int i = 0; i <= alphabet.Length; i++)
{
    if (alphabet.Length <= 5)
    {
        Console.WriteLine(alphabet);
    }
    else
    {
        Console.WriteLine("The alphabet is either empty or contains more than 26 letters.");
    }
}
*/
/*
int noteBulletin;
int grade = 0;
int minGrade;
int maxGrade;
Console.WriteLine("Enter 5 grades in order to check if you passed or not: ");
for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enter grade {i + 1} (out of /20) : ");
    noteBulletin = Convert.ToInt32(Console.ReadLine()); // Read the grade from the user
    if (noteBulletin < 0 || noteBulletin > 20)
    {
        Console.WriteLine("Invalid grade. Please enter a number between 0 and 20.");
        i--; //decrement i to repeat the input for this grade
    }
    else
    {
        grade += noteBulletin; // Add the valid grade to the total
    }
}

double average = grade / 5.0;
Console.WriteLine("your average grade is: " + average);

*/
/*
int randomNumber = new Random().Next(1, 51); 
Console.WriteLine("Guess a number between 1 and 50: ");
int userGuess = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (userGuess < 1 || userGuess > 50)
{
    Console.WriteLine("Please enter a number between 1 and 50.");
}
else
{
    while (userGuess != randomNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        if (userGuess < randomNumber)
        {
            Console.WriteLine("Too low! Try again: ");
        }
        else
        {
            Console.WriteLine("Too high! Try again: ");
        }
        count++;
        Console.ResetColor();
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congratulations! You guessed the number: " + randomNumber + " number of guesses: " + count);
    Console.ResetColor();
}

*/
/*
int[] notes = { 10, 12, 15, 8};
if (notes.Length > 0) { 
    Console.WriteLine("The average of the notes is: " + notes.Average());
}
else
{
    int[] notes2 = new int[0];
    Console.WriteLine("The notes array is empty.");
    Console.WriteLine("Please enter the number of notes.");
    int numberOfNotes = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < numberOfNotes; i++)
    {
        Console.WriteLine($"Enter note {i + 1} (out of /20): ");
        notes2[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("The average of the notes is: " + notes2.Average());
}
*/
/*
int number = 0;
while (number < 10)
{
    number++;
    Console.WriteLine(number);
}
Console.WriteLine("The loop has ended.");

int i = 1;
int sum = 0;
while (i <= 100)
{
    i++;
    sum += i;
    Console.WriteLine(sum);
}

int number2 = 0;
Console.WriteLine("Enter a number until the number is positive: ");
while (number2 <= 0)
{
    number2 = Convert.ToInt32((Console.ReadLine()));
    if (number2 <= 0)
    {
        Console.WriteLine("Please enter a positive number.");
    }
    else
    {
        Console.WriteLine("You entered a positive number: " + number2);
    }
}
*/
/*
const string password = "password123";
string inputPassword = "";
while (inputPassword != password)
{
    Console.WriteLine("Please enter your password: ");
    inputPassword = Console.ReadLine();
    if (inputPassword == password)
    {
        Console.WriteLine("You have successfully logged in.");
        break;
    }
    else
    {
        Console.WriteLine("Incorrect password, please try again.");
    }
}
*/

int number3 = 1;
while (number3 <= 10)
{
    Console.WriteLine(number3);
    number3++;
}
Console.WriteLine("end of the program");
//Class1 class1 = new Class1();
//Console.WriteLine($"The value of variable1 in Class1 is: {class1.variable1}");
/*
List<string> names;
names = new List<string> {};
int count = 0;
bool is_verified = false;
string validName = "bob";
Console.WriteLine("Enter the number of surnames needed: ");
count = Convert.ToInt32(Console.ReadLine());
if (count <= 0)
{
    Console.WriteLine("Please enter a valid number greater than 0.");
}
else
{
    Console.WriteLine("Please enter the names: ");
    
    for (int i = 0; i < count; i++)
    {
        names.Add(Console.ReadLine());
        Console.WriteLine(names[i] + " has been added to the list.");

    }
    if (names.Contains(validName))
    {
        is_verified = true;
        Console.WriteLine("The name " + validName + " is one of the verified names.");
    }
    names.RemoveAll(name => name.Length <= 4);
    Console.WriteLine("The names you entered are: " + (string.Join(", ", names)));
    Console.WriteLine("the names are sorted in alphabetical order: " + (string.Join(", ", names.OrderBy(name => name))));
}
*/

var capitals = new Dictionary<string, string>
{
    { "France", "Paris" },
    { "Germany", "Berlin" },
    { "Italy", "Rome" },
    { "Spain", "Madrid" },
    { "United Kingdom", "London"   },
    { "Japan", "Tokyo"   },
    { "China", "Beijing"   },
    { "India", "New Delhi"   },
    { "Brazil", "Brasília"   },
    { "Canada", "Ottawa"   },
    { "Australia", "Canberra" },
    { "Russia", "Moscow"   },
    { "South Africa", "Pretoria"   },
    { "Mexico", "Mexico City"   },
    { "Argentina", "Buenos Aires"   },
    { "Egypt", "Cairo"   },
    { "Turkey", "Ankara"   },
    { "Saudi Arabia", "Riyadh"   },
    { "South Korea", "Seoul"   },
    { "Indonesia", "Jakarta"   },
    { "Nigeria", "Abuja" }
};
/*
string inputCountry;
int count = 0;
bool programRunning = true;
int navigation = 0;
string countryName;
string capitalName;

while (programRunning = true)
{
    Console.WriteLine("Welcome to the Capital Finder Program!");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. add country/capital to the Database");
    Console.WriteLine("2. find a capital by country");
    Console.WriteLine("3. type 3 if you wish to leave the program");
    navigation = Convert.ToInt32(Console.ReadLine());
    if (navigation == 3)
    {
        programRunning = false;
        Console.WriteLine("Thank you for using the program. Goodbye!");
        Console.WriteLine($"You found {count} capitals.");
        break;
    }else if (navigation == 1)
    {
        Console.WriteLine("Please enter the name of the country you want to add: ");
        countryName = Console.ReadLine();
        Console.WriteLine("Please enter the capital of the country: ");
        capitalName = Console.ReadLine();
        capitals.Add(countryName, capitalName);
        Console.WriteLine($"The country {countryName} with its capital {capitalName} has been added to the database.");

    }
    else if (navigation == 2)
    {
        Console.WriteLine("Please enter the name of the country you want to find the capital for: ");
        inputCountry = Console.ReadLine().ToLower();
        foreach (var country in capitals.Keys)
        {
            if (country.ToLower() == inputCountry)
            {
                Console.WriteLine($"The capital of {country} is {capitals[country]}.");
                count++;
                break;
            }
        }
    }
    {
        {
            
        }
    }

}
*/
/*
int[] ints = { 10, 15, 20, 50, 100 };
List<string> prenoms = new List<string> { "Alice", "Bob", "Charlie", "David" };
var capitals2 = new Dictionary<string, string>
{
    { "France", "Paris" },
    { "Germany", "Berlin" },
    { "Italy", "Rome" },
};
int count1 = 0;
Console.WriteLine("les valeurs du tableau sont : ");
foreach (var item in ints)
{
    Console.Write(item + " ");
    count1++;
}
Console.WriteLine();
int count = 1;
foreach (var prenom in prenoms)
{
    Console.WriteLine(count++ + ". : " + prenom);
    count1++;
}
foreach (var capital in capitals2)
{
    Console.WriteLine($"The capital of {capital.Key} is:  {capital.Value}.");
    count1++;
}
Console.WriteLine("nombre d'éléments parcourus: " + count1);
*/
/*
int i = 0;
while (i < 10)
{
    Console.WriteLine(++i);
    if (i == 10)
    {
        Console.WriteLine("fin de la boucle");
        break;
    }
}

for (int j = 0; j < 20; j++)
{
    if (j == 11)
    {
        break;
    }
    Console.WriteLine(j);
}

Console.WriteLine("please enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (number > 0  || number < 0)
    {
        Console.WriteLine("please enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }else if (number == 0)
    {
        Console.WriteLine("end of program.");
        break;
    }
}

for (int k = 0; k < 10; k++)
{
    if (k % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(k);
}

Console.WriteLine("please enter a number and the program will display from one up to the previously input number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
for (int m = 0; m < number2; m++)
{
    if (m % 4 == 0)
    {
        continue;
    }
    Console.WriteLine(m);
}

for (int n = 0; n < 20; n++)
{
    if (n % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(n);
}
*/
/*
for (int m = 0; m <= 10; m++)
{
    for (int n = 0; n <= 10; n++)
    {
        Console.WriteLine($"{m} * {n} = {m * n}");
    }
    Console.WriteLine();
}
Console.WriteLine("Enter a number in order to display a rectangle: ");
int size = int.Parse(Console.ReadLine());

for (int i = 0; i < size; i++) // lignes
{
    for (int j = 0; j < size; j++) 
    {
        Console.Write("X");
    }
    Console.WriteLine(); 
}
*/
/*
Console.WriteLine("enter the height of the pyramid: ");
int height = int.Parse(Console.ReadLine());
for (int i = 1; i <= height; i++)
{
    for (int espace = 1; espace <= height - i; espace++)
    {
     Console.Write(" ");   
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}
*/
var list_0 = new List<object> { 5, 89, 79, 4, false };
var list_1 = new List<object> { 8, 9, 12, "azed", 7.7 };

for (int i = 0; i < list_0.Count; i++)
{
    Console.WriteLine($"{list_0[i]} \t{list_1[i]}");
}
var elements = new List<List<object>> {
    new List<object> { 5, 89, 79, 4, false },
    new List<object> { 8, 9, 12, "azed", 7.7, 9 },
    new List<object> { 7.12, "aba", 4689, true, 3 }
};

for (int i = 0; i < elements.Count; i++)
{
    for (int j = 0; j < elements[i].Count; j++)
    {
        Console.Write($"{elements[i][j]} ");
    }
    Console.WriteLine(); 
}


//Livre livre1 = new Livre("The Great Gatsby", "F. Scott Fitzgerald", 1925);