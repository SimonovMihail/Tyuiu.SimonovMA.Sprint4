using System;
using Tyuiu.SimonovMA.Sprint4.Task0.V2.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный массив на 10 элементов, заполенный статическими          *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9. Подсчитать сумму нечётных элементов   *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            Console.WriteLine(ds.GetSumOddArrEl(array));
        }
    }
}
