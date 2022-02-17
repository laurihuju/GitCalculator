using System;
using GitCalculator;

while (true)
{
    Console.WriteLine("Kirjoita lauseke tai kirjoita exit poistuaksesi:");
    string input = Console.ReadLine();
    if(input == "exit")
    {
        Console.WriteLine("Olet poistunut laskimesta.");
        break;
    }
    string result = Calculator.CalculateInput(input);
    if(result == "e")
    {
        Console.WriteLine("Annettu lauseke on virheellinen.");
        Console.WriteLine();
        continue;
    }
    Console.WriteLine("Kirjoittamasi lausekkeen tulos: " + result);
    Console.WriteLine();
}

/*string operation = ReadOperation();
int calculation = 0;
if(operation == "+")
{
    calculation = GetNumber("Kirjoita numero 1:") + GetNumber("Kirjoita numero 2:");
} else if(operation == "-")
{
    calculation = GetNumber("Kirjoita numero 1:") - GetNumber("Kirjoita numero 2:");
} else if(operation == "*")
{
    calculation = GetNumber("Kirjoita numero 1:") * GetNumber("Kirjoita numero 2:");
} else if(operation == "/")
{
    calculation = GetNumber("Kirjoita numero 1:") / GetNumber("Kirjoita numero 2:");
}
Console.WriteLine("Laskun tulos: " + calculation);*/

int GetNumber(string text)
{
    try
    {
        Console.WriteLine(text);
        int number = Int32.Parse(Console.ReadLine());
        return number;
    }
    catch(FormatException)
    {
        Console.WriteLine("Antamasi syöte ei ole numero!");
        return GetNumber(text);
    }
}

string ReadOperation()
{
    Console.WriteLine("Kirjoita suoritettava laskuoperaatio (+, -, *, /):");
    String operation = Console.ReadLine();
    if(operation == "+" || operation == "-" || operation == "*" || operation == "/")
        return operation;

    Console.WriteLine("Laskuoperaatiota " + operation + " ei tunnistettu!");
    Console.WriteLine();
    return ReadOperation();
}