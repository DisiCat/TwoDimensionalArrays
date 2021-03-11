using System;

namespace FindTheIndexOfTheMaximumElementOfAnArray
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

            int maxIndexI = 0;
            int maxindexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxIndexI, maxindexJ] < array[i, j])
                    {
                        maxIndexI = i;
                        maxindexJ = j;
                    }
                }
            }

            Console.WriteLine($" The index of the maximum element of the array = [{maxIndexI}, {maxindexJ}]");
        }
    }
}
