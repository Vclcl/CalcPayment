using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcModel
{
    /// <summary>
    /// Тестовая реализация репозитория курсов валют
    /// </summary>
    class RateRepository : IRateRepository
    {
        CurrencyState[] _currencyList = { new CurrencyState("USD", 64.422m),
                                          new CurrencyState("EUR", 74.693m),
                                          new CurrencyState("GBP", 98.3889m)};

        public IEnumerable<string> CurrencyCollection()
        {
            return _currencyList.Select(x => x.Name);
        }

        public decimal ExchangeRate(string currencyName)
        {
            CurrencyState instance = _currencyList.FirstOrDefault(x => x.Name == currencyName);
            if (instance != null)
            {
                return instance.ExchangeRate;
            }
            else
            {
                return 0m;
            }
        }
    }
}
