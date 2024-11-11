using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SimonovMA.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(n => n.Length > 6);
            return count;
        }
    }
}
