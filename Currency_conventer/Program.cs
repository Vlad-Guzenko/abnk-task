using System;

namespace Currency_conventer
{
    class Program
    {
        static void Main(string[] args)
        {
            var currencyExchanger = new CurrencyExchanger();

            var exchangeCurrencyScenario = new ExchangeCurrencyScenario(currencyExchanger);
            var addCurrencyScenario = new AddCurrencyScenario(currencyExchanger);

            char choise;

            do
            {
                currencyExchanger.ShowMenu();
                choise = Console.ReadKey().KeyChar;
                if (choise == '1')
                {
                    exchangeCurrencyScenario.Run();
                }
                else if (choise == '2')
                {
                    addCurrencyScenario.Run();
                }
            } while (choise != '3');
        }
    }
}