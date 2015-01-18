using MvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /Home/
        
        [HttpPost]
        public ActionResult Index(CalcView input)
        {
            if (ModelState.IsValid)
            {
                CalcModel.CalcPay calc = new CalcModel.CalcPay();
                calc.CountPayment = input.CountPayment;
                calc.ExchangeRate = input.ExchangeRate;
                calc.FirstDate = input.FirstDate;
                calc.NDS = input.NDS;
                calc.Sum = input.Sum;
                input.PaymentShedule = calc.PaymentShedule();
                input.TotalSum = calc.GetTotalSum();
                return View(input);
            }
            return View();
        }

    }
}
