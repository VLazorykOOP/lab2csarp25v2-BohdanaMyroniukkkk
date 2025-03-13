using System;

class Program3
{
    static void Main3(string[] args)
    {
        Console.WriteLine("Введiть розмiр матрицi n:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Помилка: розмiр має бути бiльше 0!");
            return;
        }

        int[,] matrix = new int[n, n];

        Console.WriteLine("Введiть елементи матрицi:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nМатриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nЕлементи матрицi в порядку змiйки:");
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) 
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            else 
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
        Console.WriteLine();
    }
}