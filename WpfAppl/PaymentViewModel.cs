﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfAppl
{
    public class PaymentViewModel
    {
        public DateTime Date { get; set; }
        public decimal Sum { get; set; }
        public PaymentViewModel(DateTime date, decimal sum)
        {
            Date = date;
            Sum = sum;
        }
    }
}
