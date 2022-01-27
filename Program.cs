using System;

int calculation = getNumber("Kirjoita numero 1:") + getNumber("Kirjoita numero 2:");
Console.WriteLine(calculation);

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