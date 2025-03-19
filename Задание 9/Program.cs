using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Console.Write("Введите начальный индекс для удаления: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество символов для удаления: ");
        int length = Convert.ToInt32(Console.ReadLine());

        StringBuilder sb = new StringBuilder(input);

        if (startIndex >= 0 && startIndex + length <= sb.Length)
        {
            sb.Remove(startIndex, length);
            Console.WriteLine("Результат после удаления:");
            Console.WriteLine(sb.ToString());
        }
        else
        {
            Console.WriteLine("Ошибка: недопустимый диапазон.");
        }
    }
}