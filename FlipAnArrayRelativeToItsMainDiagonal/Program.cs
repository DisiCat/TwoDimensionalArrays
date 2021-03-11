using System;

namespace FlipAnArrayRelativeToItsMainDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 5];
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

            if (array.GetLength(0) == array.GetLength(1))
            {
                int temp;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i; j < array.GetLength(1); j++)
                    {
                        if (i != j)
                        {
                            temp = array[i, j];
                            array[i, j] = array[j, i];
                            array[j, i] = temp;
                        }
                    }
                }

                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"[{array[i, j]}]");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                int[,] rectangularMatrix = new int[array.GetLength(1), array.GetLength(0)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        rectangularMatrix[j, i] = array[i, j];
                    }
                }

                Console.WriteLine();
                for (int i = 0; i < rectangularMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < rectangularMatrix.GetLength(1); j++)
                    {
                        Console.Write($"[{ rectangularMatrix[i, j]}]");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
