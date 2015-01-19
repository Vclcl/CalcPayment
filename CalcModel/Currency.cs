using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcModel
{
    public class CurrencyState
    {
        public string Name { get; set; }
        public decimal ExchangeRate { get; set; }
        public CurrencyState(string name, decimal exchangeRate)
        {
            Name = name;
            ExchangeRate = exchangeRate;
        }
    }
}
