using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KultyshevaEA.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 100;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(2.54, res);
        }
    }
}
