using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KolchakovDR.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            var res = ds.Calculate(k);
            Assert.AreEqual(9, res);
            
        }
    }
}
