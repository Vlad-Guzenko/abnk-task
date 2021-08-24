using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conventer
{
    class Exchanging
    {
        public Exchanging(CurrencyChanger currencyChanger)
        {
            currencyChanger = new CurrencyChanger();
        }
        public void ExchangeCurrency(CurrencyChanger currencyChanger, int first, int second, float amount)
        {
            Console.Clear();
            foreach (var x in currencyChanger.Currencies.Select((value, index) => new { value, index }))
                Console.WriteLine(x.index + 1 + ". " + x.value.ISO + " " + x.value.CurrencyRate);
            try
            {
                Console.WriteLine("\nType appropriate digit to select currency: ");
                first = int.Parse(Console.ReadLine());
                var firstVal = currencyChanger.Currencies.ElementAt(first - 1);
                Console.WriteLine("Source currency selected: " + firstVal.ISO + " " + firstVal.CurrencyRate);
                Console.WriteLine("\nSelect your destination currency: ");
                second = int.Parse(Console.ReadLine());
                var secondVal = currencyChanger.Currencies.ElementAt(second - 1);
                Console.WriteLine("Destination currency selected: " + secondVal.ISO + " " + secondVal.CurrencyRate);
                Console.WriteLine("\nEnter your source currency amount: ");
                amount = float.Parse(Console.ReadLine());
                Console.WriteLine("\nFinnaly you have: " + " " + secondVal.ISO + ": " + Math.Round(firstVal.CurrencyRate * amount / secondVal.CurrencyRate, 4));
                Console.WriteLine("\nPress backspace to return to the main menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nEnter backspace to return...");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace) ;
        }
    }
}
