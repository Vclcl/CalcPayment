using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcModel
{
    public struct Payment
    {
        public DateTime Date;
        public decimal Sum;
        public Payment(DateTime date, decimal sum)
        {
            Date = date;
            Sum = sum;
        }
        public Payment(int year, int month, int day, decimal sum)
        {
            Date = new DateTime(year, month, day);
            Sum = sum;
        }
    }
}
