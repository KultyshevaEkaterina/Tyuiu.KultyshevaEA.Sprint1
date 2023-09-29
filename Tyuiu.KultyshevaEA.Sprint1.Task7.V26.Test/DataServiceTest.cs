﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint1.Task7.V26.Lib;

namespace Tyuiu.KultyshevaEA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 1.115;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
