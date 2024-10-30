using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SimonovMA.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
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
