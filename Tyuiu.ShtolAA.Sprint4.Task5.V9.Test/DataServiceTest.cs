using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.ShtolAA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { {-4,1,4,2,3 },
                                          { -2,-1,3,1,2},
                                          { -1,3,2,3,3},
                                          { 1,2,3,4,3 },
                                          { -2,-3,1,2,3}};
            int res = ds.Calculate(matrix);
            int wait = 19;

            Assert.AreEqual(wait, res);
        }
    }
}
