using System;
using Tyuiu.SimonovMA.Sprint4.Task3.V1.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Симонов Михаил Алексеевич | РППб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Найти сумму элементов в  *");
            Console.WriteLine("* последнем столбце массива.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив 5 на 5 с цифрами.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] array = {
            {3, 4, 3, 4, 1},
            {8, 1, 6, 6, 9},
            {9, 8, 5, 1, 3},
            {1, 8, 7, 1, 2},
            {9, 9, 7, 5, 6}
            };

            Console.WriteLine(ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
