using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcModel
{
    public class RateRepository
    {
        CurrencyState[] _currencyList = { new CurrencyState("USD", 64.422m),
                                          new CurrencyState("EUR", 74.693m),
                                          new CurrencyState("GBP", 98.3889m)};
        IEnumerable<string> CurrencyCollection()
        {
            return _currencyList.Select(x => x.Name);
        }
        decimal ExchangeRate(string currencyName)
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
