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
    }
}
