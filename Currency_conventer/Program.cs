using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Currency_conventer
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency currency = new Currency();
            CurrencyChanger currencyChanger = new CurrencyChanger();
            Exchanging exchanging = new Exchanging(currencyChanger);
            Adding adding = new Adding(currencyChanger);
            int first = 0, second = 0; float amount = 1; char choise = ' ';
            do
            {
                currencyChanger.ShowMenu();
                choise = Console.ReadKey().KeyChar;
                if (choise == '1')
                {
                    exchanging.ExchangeCurrency(currencyChanger, first, second, amount);
                }
                else if (choise == '2')
                {
                    adding.AddCurrency(currencyChanger);
                }
            } while (choise != '3');
        }
    }
}