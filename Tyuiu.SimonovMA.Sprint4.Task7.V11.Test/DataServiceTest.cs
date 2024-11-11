using System;
using Tyuiu.SimonovMA.Sprint4.Task7.V11.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void final_test()
        {
            DataService ds = new DataService();
            int rows = 4;
            int columns = 2;
            string value = "56789012";

            int result = ds.Calculate(rows, columns, value);

            Assert.AreEqual(4, result);
        }
    }
}