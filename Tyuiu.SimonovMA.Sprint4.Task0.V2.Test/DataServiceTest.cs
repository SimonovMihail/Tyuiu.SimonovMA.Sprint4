using System;
using Tyuiu.SimonovMA.Sprint4.Task0.V2.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int sum = 0;
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            sum = ds.GetSumOddArrEl(array);
            Assert.AreEqual(44, sum);
        }
    }
}