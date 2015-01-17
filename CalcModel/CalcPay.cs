using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcModel
{
    public class CalcPay
    {
        public decimal Sum { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal NDS { get; set; }
        public int CountPayment { get; set; }
        public DateTime FirstDate { get; set; }
        public decimal SumWithNDS()
        {
            return Sum * (NDS / 100 + 1m);
        }
        public decimal GetTotalSum()
        {
            return SumWithNDS() * ExchangeRate;
        }
        public IEnumerable<Payment> PaymentShedule()
        {
            decimal MounthPayment = GetTotalSum() / CountPayment;
            for (int i = 0; i < CountPayment; i++)
            {
                yield return new Payment(FirstDate.AddMonths(i), MounthPayment);
            }
        }
    }
}
