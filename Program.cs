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