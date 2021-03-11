using System;

namespace FindTheNumberOfArrayElementsThatAreLargerThanAllTheirNeighborsAtTheSameTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 10);
                    Console.Write($"[{array[i, j]}]");
                }
                Console.WriteLine();
            }

            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    var conditionsPassed = true;
                    for (int k = -1; k <= 1 && conditionsPassed; k++)
                    {
                        int NewIndexI = i - k;
                        for (int l = -1; l <= 1; l++)
                        {
                            int NewIndexJ = j - l;
                            if((NewIndexI != i || NewIndexJ != j) 
                               &&NewIndexI >= 0 && NewIndexI < array.GetLength(0)
                               &&NewIndexJ >= 0 && NewIndexJ < array.GetLength(1)
                               &&array[i, j] <= array[NewIndexI, NewIndexJ])
                            {
                                conditionsPassed = false;
                                break;
                            }
                        }
                    }

                    if (conditionsPassed)
                    {
                        ++counter;
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
