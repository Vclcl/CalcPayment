using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcModel
{
    public class Payment
    {
        public DateTime Date { get; set; }
        public decimal Sum { get; set; }
        public Payment(DateTime date, decimal sum)
        {
            Date = date;
            Sum = sum;
        }
    }
}
