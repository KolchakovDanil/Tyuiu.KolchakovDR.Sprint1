using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint1.Task3.V7.Lib;
namespace Tyuiu.KolchakovDR.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 100;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(106.68, res);
        }
    }
}
