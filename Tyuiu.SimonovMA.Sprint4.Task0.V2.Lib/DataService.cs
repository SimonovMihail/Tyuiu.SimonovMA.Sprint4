using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SimonovMA.Sprint4.Task0.V2.Lib
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach(int number in array)
            {
                if (number % 2 != 0)
                {
                    sum = sum + number;
                }
            }
            return sum;
        }
    }
}
