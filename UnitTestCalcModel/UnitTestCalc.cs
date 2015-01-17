using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcModel;
using System.Linq;

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
        [TestMethod]
        public void TestPaymentShedule()
        {
            CalcPay calc = new CalcPay();
            calc.Sum = 125000m;
            calc.ExchangeRate = 33.78m;
            calc.NDS = 18m;
            calc.CountPayment = 3;
            calc.FirstDate = new DateTime(2014, 1, 1);
            Payment[] sample = {new Payment(new DateTime(2014, 1, 1), 1660850m),
                                new Payment(new DateTime(2014, 2, 1), 1660850m),
                                new Payment(new DateTime(2014, 3, 1), 1660850m)};
            Assert.AreEqual(true, sample.SequenceEqual(calc.PaymentShedule()));
        }
    }
}
