using System;
using Tyuiu.SimonovMA.Sprint4.Task2.V2.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void random_check()
        {
            DataService ds = new DataService();

            int[] array = new int[11];
            int result = ds.Calculate(array);

            Assert.AreEqual(true, result % 2 != 0);
        }
    }
}