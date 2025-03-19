using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        double[] numbers = new double[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += numbers[i];
        }

        double average = sum / size;

        Console.WriteLine($"Среднее арифметическое: {average}");
    }
}