using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint1.Task0.V26.Lib;

namespace Tyuiu.KolchakovDR.Sprint1.Task0.V26.Test
{

    /// 4*5/2-18/2/3
    /// 10-3=7
    
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
