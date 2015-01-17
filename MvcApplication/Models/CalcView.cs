using CalcModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class CalcView
    {
        public decimal Sum { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal NDS { get; set; }
        public int CountPayment { get; set; }
        public DateTime FirstDate { get; set; }
        IEnumerable<Payment> PaymentShedule { get; set;}
    }
}