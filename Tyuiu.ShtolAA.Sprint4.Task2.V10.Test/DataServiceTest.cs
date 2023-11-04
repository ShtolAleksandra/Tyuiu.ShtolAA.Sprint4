using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint4.Task2.V10.Lib;

namespace Tyuiu.ShtolAA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = {4,5,6,4,1,2,3,3,2,1,3,4,5};
            int res = ds.Calculate(array);
            int wait = 675;
            Assert.AreEqual(wait, res);
        }
    }
}
