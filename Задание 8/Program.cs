// See https://ausing System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку для проверки: ");
        string input = Console.ReadLine();

        bool isValidIdentifier = IsValidIdentifier(input);

        if (isValidIdentifier)
        {
            Console.WriteLine($"'{input}' является допустимым идентификатором C#.");
        }
        else
        {
            Console.WriteLine($"'{input}' не является допустимым идентификатором C#.");
        }
    }

    static bool IsValidIdentifier(string identifier)
    {

        if (string.IsNullOrEmpty(identifier))
            return false;

        return Regex.IsMatch(identifier, @"^[a-zA-Z_][a-zA-Z0-9_]*$");
    }
}