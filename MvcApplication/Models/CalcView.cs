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
        [Display(Name = "Сумма в валюте")]
        [Required(ErrorMessage = "Сумма в валюте незаполнена")]
        public decimal Sum { get; set; }

        [Display(Name = "Курс")]
        [Required(ErrorMessage = "Курс валюты незаполнен")]
        public decimal ExchangeRate { get; set; }

        [Display(Name = "НДС")]
        [Required(ErrorMessage = "НДС незаполнен")]
        public decimal NDS { get; set; }

        [Display(Name = "Количество платежей")]
        [Required(ErrorMessage = "Количество платежей незаполнено")]
        public int CountPayment { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата первого платежа")]
        [Required(ErrorMessage = "Дата первого платежа незаполнена")]
        public DateTime FirstDate { get; set; }

        public IEnumerable<Payment> PaymentShedule { get; set;}

        [Display(Name = "Итого")]
        public decimal TotalSum { get; set; }
    }
}