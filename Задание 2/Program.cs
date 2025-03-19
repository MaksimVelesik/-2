using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        double average = 0;
        foreach (var num in array) average += num;
        average /= n;

        for (int i = 0; i < n; i++)
        {
            if (array[i] < 0) array[i] += 0.5;
            else if (array[i] < average) array[i] = 0.1;
        }

        Array.Sort(array);
        Console.WriteLine("Измененный и отсортированный массив: " + string.Join(", ", array));

        Console.Write("Введите число k для бинарного поиска: ");
        double k = Convert.ToDouble(Console.ReadLine());
        int index = Array.BinarySearch(array, k);
        Console.WriteLine(index >= 0 ? $"Число {k} найдено на индексе {index}." : $"Число {k} не найдено.");
    }
}