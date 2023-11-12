using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint4.Task4.V30.Lib;

namespace Tyuiu.ShtolAA.Sprint4.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] array = { {3, 4, 6, 6, 5},
                             { 6, 7, 6, 3, 5},
                             { 5, 3, 5, 7, 6},
                             { 6, 4, 7, 6, 6 },
                             { 7, 4, 3, 4, 5}};
           
            int[,] wait = {{0, 4, 6, 6, 0},
                        { 6, 0, 6, 0, 0},
                        { 0, 0, 0, 0, 6},
                        { 6, 4, 0, 6, 6 },
                        { 0, 4, 0, 4, 0}}; 

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
