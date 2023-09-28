using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.KultyshevaEA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "cat";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "ct";
            Assert.AreEqual(wait, res);
        }
    }
}
