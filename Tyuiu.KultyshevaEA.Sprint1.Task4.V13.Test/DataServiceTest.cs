using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint1.Task4.V13.Lib;

namespace Tyuiu.KultyshevaEA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 6;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
