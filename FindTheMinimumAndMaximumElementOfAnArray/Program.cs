using System;

namespace FindTheMinimumAndMaximumElementOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10, 100);
                    Console.Write($"[{array[i, j]}]");
                }
                Console.WriteLine();
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
                Console.WriteLine($" minimum element of an array = { min}");
                Console.WriteLine($" maximum array element = {max}");
        }
    }
}
