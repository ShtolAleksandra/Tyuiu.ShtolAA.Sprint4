using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint4.Task7.V29.Lib;

namespace Tyuiu.ShtolAA.Sprint4.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string str = "983157642891";
            int rows = 4;
            int columns = 3;
            int wait = 28;
            int res = ds.Calculate(rows, columns, str);
            Assert.AreEqual(wait, res);
        }
    }
}
