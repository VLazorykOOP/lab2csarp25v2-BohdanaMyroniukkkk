using System;

class Program2
{
    static void Main2(string[] args)
    {
        Console.WriteLine("Введiть розмiр послiдовностi (n):");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Помилка: розмiр має бути бiльше 0!");
            return;
        }

        double[] numbers = new double[n];

        Console.WriteLine("Введiть " + n + " дiйсних чисел:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double maxNegative = double.MinValue; 
        bool hasNegative = false; 

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < 0) 
            {
                hasNegative = true;
                if (numbers[i] > maxNegative) 
                {
                    maxNegative = numbers[i];
                }
            }
        }

        if (hasNegative)
        {
            Console.WriteLine("Максимум серед вiд'ємних елементiв: " + maxNegative);
        }
        else
        {
            Console.WriteLine("Вiд'ємних елементiв немає.");
        }
    }
}