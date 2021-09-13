using System;
using System.Collections.Generic;
using System.Linq;

namespace Currency_conventer
{
    public class CurrencyExchanger
    {
        private readonly List<Currency> _currencies;
        public IReadOnlyCollection<Currency> Currencies => _currencies;

        public CurrencyExchanger()
        {
            _currencies = new List<Currency>
            {
                new Currency { ISO = "USD", CurrencyRate = 26.71f },
                new Currency { ISO = "EUR", CurrencyRate = 31.45f }
            };
        }

        public void ShowMenu()
        {
            ShowCurrency();
            Console.WriteLine("\n1. Exchange currency" + "\n2. Add new currency" + "\n3. Exit");
        }

        internal void AddCurrency(string iso, float rate)
        {
            _currencies.Add(new Currency { ISO = iso, CurrencyRate = rate });
        }

        internal float ExchangeCurrency(Currency sourceCurrency, Currency destinationCurrency, float sourceAmount)
        {
            return (float)Math.Round(sourceCurrency.CurrencyRate * sourceAmount / destinationCurrency.CurrencyRate, 4);
        }

        public void ShowCurrency()
        {
            Console.Clear();

            Console.WriteLine("Available currency: " + "\n--------------------");

            foreach (var x in _currencies.Select((value, index) => new { value, index }))
            {
                Console.WriteLine(x.value.ISO + " " + x.value.CurrencyRate);
            }
        }
    }
}
