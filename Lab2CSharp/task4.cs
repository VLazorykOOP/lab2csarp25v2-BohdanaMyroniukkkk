using System;

class Program4
{
    static void Main4(string[] args)
    {
        Console.WriteLine("Введiть кiлькiсть рядкiв (n):");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Помилка: кiлькiсть рядкiв має бути бiльше 0!");
            return;
        }

        int[][] jaggedArray = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введiть кiлькiсть елементiв у рядку {i + 1} (mj):");
            int mj = Convert.ToInt32(Console.ReadLine());

            if (mj <= 0)
            {
                Console.WriteLine("Помилка: кiлькiсть елементiв у рядку має бути бiльше 0!");
                return;
            }

            jaggedArray[i] = new int[mj];

            Console.WriteLine($"Введiть {mj} елементiв для рядка {i + 1}:");
            for (int j = 0; j < mj; j++)
            {
                jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nСхiдчастий масив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        int[] sums = new int[n];

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                sum += jaggedArray[i][j];
            }
            sums[i] = sum;
        }

        Console.WriteLine("\nМасив сум рядкiв:");
        for (int i = 0; i < sums.Length; i++)
        {
            Console.WriteLine($"Сума рядка {i + 1}: {sums[i]}");
        }

        int maxSum = sums[0];
        for (int i = 1; i < sums.Length; i++)
        {
            if (sums[i] > maxSum)
            {
                maxSum = sums[i];
            }
        }

        Console.WriteLine($"\nМаксимальний елемент серед сум: {maxSum}");
    }
}