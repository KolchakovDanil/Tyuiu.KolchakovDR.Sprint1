using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint1.Task6.V16.Lib;
namespace Tyuiu.KolchakovDR.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "Всем привет!";
            var res = ds.CheckSpecSymbols(text);
            Assert.AreEqual(true, res);
        }
    }
}
