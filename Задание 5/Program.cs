using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, cols];
        Random rand = new Random();

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(-10, 10); 
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int nonZeroRows = 0;
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }
            if (sum != 0) nonZeroRows++;
        }

        int[,] result = new int[nonZeroRows, cols];
        int currentRow = 0;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }
            if (sum != 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[currentRow, j] = array[i, j];
                }
                currentRow++;
            }
        }

        Console.WriteLine("Массив без строк с нулевой суммой:");
        for (int i = 0; i < nonZeroRows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}