using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N (N < 10): ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[N, N];
        Random rand = new Random();

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sumOfSquares = 0;
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                if (matrix[i, j] > C) sumOfSquares += matrix[i, j] * matrix[i, j];

        Console.WriteLine($"Сумма квадратов элементов, больших C: {sumOfSquares}");

        Console.WriteLine("Среднее арифметическое каждой строки:");
        for (int i = 0; i < N; i++)
        {
            double rowSum = 0;
            for (int j = 0; j < N; j++) rowSum += matrix[i, j];
            Console.WriteLine($"Строка {i + 1}: {rowSum / N}");
        }
    }
}