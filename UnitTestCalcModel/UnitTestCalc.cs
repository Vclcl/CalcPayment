using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcModel;

namespace UnitTestCalcModel
{
    [TestClass]
    public class UnitTestCalc
    {
        [TestMethod]
        public void TestTotalSum()
        {
            CalcPay calc = new CalcPay();
            calc.Sum = 125000m;
            calc.ExchangeRate = 33.78m;
            calc.NDS = 18m;
            Assert.AreEqual(calc.GetTotalSum(), 4982550m);
        }
    }
}
