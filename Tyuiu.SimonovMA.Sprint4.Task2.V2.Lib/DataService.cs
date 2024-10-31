using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SimonovMA.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 8);
            }

            int result = 1;

            foreach (int n in array)
            {
                if (n % 2 != 0)
                {
                    result = result * n;
                }
            }

            return result;
        }
    }
}
