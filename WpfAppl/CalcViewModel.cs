using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalcModel;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfAppl
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        private CalcPay _calcPay = new CalcPay();

        public decimal Sum
        {
            get { return _calcPay.Sum; }
            set { _calcPay.Sum = value; NotifyPropertyChanged("TotalSum"); NotifyPropertyChanged("PaymentShedule"); }
        }

        public decimal NDS
        {
            get { return _calcPay.NDS; }
            set { _calcPay.NDS = value; NotifyPropertyChanged("TotalSum"); NotifyPropertyChanged("PaymentShedule"); }
        }

        public decimal ExchangeRate
        {
            get { return _calcPay.ExchangeRate; }
            set { _calcPay.ExchangeRate = value; NotifyPropertyChanged("TotalSum"); NotifyPropertyChanged("PaymentShedule"); }
        }

        public DateTime FirstDate
        {
            get { return _calcPay.FirstDate; }
            set { _calcPay.FirstDate = value; NotifyPropertyChanged("PaymentShedule"); }
        }

        public int CountPayment
        {
            get { return _calcPay.CountPayment; }
            set { _calcPay.CountPayment = value; NotifyPropertyChanged("TotalSum"); NotifyPropertyChanged("PaymentShedule"); }
        }

        public IEnumerable<PaymentViewModel> PaymentShedule
        {
            get 
            {
                IEnumerable<Payment> listPay = _calcPay.PaymentShedule();
                var query = from Payment pay in listPay select new PaymentViewModel(pay.Date, pay.Sum);
                return query; 
            }
        }

        public decimal TotalSum
        {
            get { return _calcPay.GetTotalSum(); }
        }

        public IEnumerable<string> CurrencyCollection
        {
            get { return _calcPay.CurrencyCollection(); }
        }

        public string Currency
        {
            get { return _calcPay.Currency; }
            set 
            {
                _calcPay.Currency = value;
                NotifyPropertyChanged("ExchangeRate");
                NotifyPropertyChanged("TotalSum");
                NotifyPropertyChanged("PaymentShedule");}
        }
        
        

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
