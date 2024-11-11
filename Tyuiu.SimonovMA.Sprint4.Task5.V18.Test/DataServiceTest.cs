using System;
using Tyuiu.SimonovMA.Sprint4.Task5.V18.Lib;

namespace Tyuiu.SimonovMA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void mmmmmmmmm()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -1, -1, -1, -1, -1 },
                              { -1, -1, -1, -1, -1 },
                              { -1, -1, -1, -1, -1 },
                              { -1, -1, -1, -1, -1 },
                              { -1, -1, -1, -1, -1 }, };

            int[,] expectedMatrix = { { 0, 0, 0, 0, 0 },
                                   { 0, 0, 0, 0, 0 },
                                   { 0, 0, 0, 0, 0 },
                                   { 0, 0, 0, 0, 0 },
                                   { 0, 0, 0, 0, 0 }, };

            int[,] resultMatrix = ds.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedMatrix[i, j], resultMatrix[i, j],
                        $"Mismatch at position [{i}, {j}]. Expected: {expectedMatrix[i, j]}, Actual: {resultMatrix[i, j]}");
                }
            }
        }
    }
}