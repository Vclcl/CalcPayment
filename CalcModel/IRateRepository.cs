using System;
namespace CalcModel
{
    interface IRateRepository
    {
        System.Collections.Generic.IEnumerable<string> CurrencyCollection();
        decimal ExchangeRate(string currencyName);
    }
}
