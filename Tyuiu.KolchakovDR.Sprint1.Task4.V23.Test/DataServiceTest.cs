using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint1.Task4.V23.Lib;
namespace Tyuiu.KolchakovDR.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 7;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(3, res);
        }
    }
}
