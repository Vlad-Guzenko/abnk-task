using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conventer
{
    class CurrencyChanger
    {
        private readonly List<Currency> _currencies = new List<Currency>() {
            new Currency{ ISO = "USD", CurrencyRate = 26.71f},
            new Currency{ ISO = "EUR", CurrencyRate = 31.45f}
        };

        public List<Currency> Currencies
        {
            get { return _currencies; }
        }

        public void ShowMenu()
        {
            ShowCurrency();
            Console.WriteLine("\n1. Exchange currency" + "\n2. Add new currency" + "\n3. Exit");
        }
        public void ShowCurrency()
        {
            Console.Clear();
            Console.WriteLine("Available currency: " + "\n--------------------");
            foreach (var x in _currencies.Select((value, index) => new { value, index }))
                Console.WriteLine(x.value.ISO + " " + x.value.CurrencyRate);
        }
    }
}
