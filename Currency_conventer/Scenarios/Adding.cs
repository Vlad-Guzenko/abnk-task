using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conventer
{
    class Adding
    {
        public Adding(CurrencyChanger currencyChanger)
        {
            currencyChanger = new CurrencyChanger();
        }
        public void AddCurrency(CurrencyChanger currencyChanger)
        {
            string iso; float rate;
            Console.Clear();
            Console.WriteLine("Enter ISO and Rate" + "\nISO: ");
            try
            {
                iso = Console.ReadLine();
                Console.WriteLine("Rate: ");
                rate = float.Parse(Console.ReadLine());
                currencyChanger.Currencies.Add(new Currency { ISO = iso, CurrencyRate = rate });
                Console.WriteLine("Currency has been added!" + "\nPress backspace to return to the main menu...");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nEnter backspace to return...");

            }while (Console.ReadKey().Key != ConsoleKey.Backspace) ;
        }
    }
}
