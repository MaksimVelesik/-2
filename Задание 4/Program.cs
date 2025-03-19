using System;

class Program
{
    static void Main()
    {
        const int shops = 10; 
        const int months = 12;

        double[,] income = new double[shops, months];
        Random rand = new Random();

        for (int i = 0; i < shops; i++)
            for (int j = 0; j < months; j++)
                income[i, j] = rand.Next(1000, 5000);

        Console.Write("Введите заданное число для сравнения с доходом в сентябре: ");
        double threshold = Convert.ToDouble(Console.ReadLine());

        double septemberIncome = 0;
        for (int i = 0; i < shops; i++)
            septemberIncome += income[i, 8];

        Console.WriteLine($"Общий доход в сентябре: {septemberIncome}");
        Console.WriteLine(septemberIncome > threshold ?
            "Доход в сентябре превышает заданное число." :
            "Доход в сентябре не превышает заданное число.");
    }
}