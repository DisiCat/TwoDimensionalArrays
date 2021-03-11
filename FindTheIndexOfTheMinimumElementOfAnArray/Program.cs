using System;

namespace FindTheIndexOfTheMinimumElementOfAnArray
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

            int minIndexI = 0;
            int minindexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minIndexI, minindexJ] > array[i, j])
                    {
                        minIndexI = i;
                        minindexJ = j;
                    }
                }
            }
            Console.WriteLine($"The index of the minimum element of the array = [{minIndexI}, {minindexJ}]");
        }
    }
}
