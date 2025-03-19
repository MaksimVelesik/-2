using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Массив слов:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}