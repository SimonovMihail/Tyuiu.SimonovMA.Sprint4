using System;
using Tyuiu.SimonovMA.Sprint4.Task1.V4.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void methodusu_checkusu()
        {
            DataService ds = new DataService();
            int res = 0;
            int[] array = new int[10] { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            res = ds.Calculate(array);
            Assert.AreEqual(2835, res);
        }
    }
}