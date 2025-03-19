using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string result = RemovePunctuation(input);

        Console.WriteLine("Строка без знаков препинания:");
        Console.WriteLine(result);
    }

    static string RemovePunctuation(string input)
    {
        char[] punctuation = { '.', ',', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '\'', '\"' };
        foreach (char ch in punctuation)
        {
            input = input.Replace(ch.ToString(), "");
        }
        return input;
    }
}