﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint4.Task1.V15.Lib;

namespace Tyuiu.ShtolAA.Sprint4.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6,7,6,7,5,7,6,7,9,4,6,5,8,5 };
            int res = ds.Calculate(array);
            int wait = 41472;

            Assert.AreEqual(wait, res);
        }
    }
}
