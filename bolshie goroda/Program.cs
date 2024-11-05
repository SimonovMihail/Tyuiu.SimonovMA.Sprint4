﻿namespace bolshie_goroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 2, 5, 8, 7 },
                                        { 6, 7, 2, 5 },
                                        { 6, 4, 8, 2 },
                                        { 2, 7, 6, 3 } };

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
