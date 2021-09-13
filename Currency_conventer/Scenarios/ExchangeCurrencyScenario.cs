using System;
using System.Linq;

using Currency_conventer.Scenarios;

namespace Currency_conventer
{
    class ExchangeCurrencyScenario : BaseScenario
    {
        public ExchangeCurrencyScenario(CurrencyExchanger currencyExchanger) : base (currencyExchanger)
        {}

        public override void Run()
        {
            Console.Clear();
            foreach (var x in CurrencyExchanger.Currencies.Select((value, index) => new { value, index }))
                Console.WriteLine(x.index + 1 + ". " + x.value.ISO + " " + x.value.CurrencyRate);
            try
            {
                Console.WriteLine("\nType appropriate digit to select currency: ");

                var first = int.Parse(Console.ReadLine());
                var sourceCurrency = CurrencyExchanger.Currencies.ElementAt(first - 1);

                Console.WriteLine("Source currency selected: " + sourceCurrency.ISO + " " + sourceCurrency.CurrencyRate);
                Console.WriteLine("\nSelect your destination currency: ");

                var second = int.Parse(Console.ReadLine());
                var destinationCurrency = CurrencyExchanger.Currencies.ElementAt(second - 1);

                Console.WriteLine("Destination currency selected: " + destinationCurrency.ISO + " " + destinationCurrency.CurrencyRate);
                Console.WriteLine("\nEnter your source currency amount: ");

                var sourceAmount = float.Parse(Console.ReadLine());

                var destinationAmount = CurrencyExchanger.ExchangeCurrency(sourceCurrency, destinationCurrency, sourceAmount);

                Console.WriteLine("\nFinnaly you have: " + " " + destinationCurrency.ISO + ": " + destinationAmount);
                Console.WriteLine("\nPress backspace to return to the main menu...");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nEnter backspace to return...");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace) ;
        }
    }
}
