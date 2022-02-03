using System;

/*string operation = readOperation();
int calculation = 0;
if(operation == "+")
{
    calculation = getNumber("Kirjoita numero 1:") + getNumber("Kirjoita numero 2:");
} else if(operation == "-")
{
    calculation = getNumber("Kirjoita numero 1:") - getNumber("Kirjoita numero 2:");
} else if(operation == "*")
{
    calculation = getNumber("Kirjoita numero 1:") * getNumber("Kirjoita numero 2:");
} else if(operation == "/")
{
    calculation = getNumber("Kirjoita numero 1:") / getNumber("Kirjoita numero 2:");
}*/
int number1 = getNumber("Kirjoita numero 1:");
int number2 = getNumber("Kirjoita numero 2:");
int summa = number1 + number2;
int erotus = number1 - number2;
Console.WriteLine("summa = " + summa);
Console.WriteLine("erotus = " + erotus);

int getNumber(string text)
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
        return getNumber(text);
    }
}

string readOperation()
{
    Console.WriteLine("Kirjoita suoritettava laskuoperaatio:");
    String operation = Console.ReadLine();
    if(operation == "+" || operation == "-" || operation == "*" || operation == "/")
        return operation;

    Console.WriteLine("Laskuoperaatiota " + operation + " ei tunnistettu!");
    Console.WriteLine();
    return readOperation();
}