using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть розмiр масиву:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Введiть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Номери (iндекси) непарних елементiв:");
        bool hasOdd = false; 

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0) 
            {
                Console.Write(i + " ");
                hasOdd = true;
            }
        }

        if (!hasOdd)
        {
            Console.WriteLine("Непарних елементiв немає.");
        }
        Console.WriteLine();
    }
}