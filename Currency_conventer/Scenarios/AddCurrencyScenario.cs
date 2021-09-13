using System;

using Currency_conventer.Scenarios;

namespace Currency_conventer
{
    class AddCurrencyScenario : BaseScenario
    {
        public AddCurrencyScenario(CurrencyExchanger currencyExchanger) : base(currencyExchanger)
        {}

        public override void Run()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Enter ISO and Rate" + "\nISO: ");

                string iso = Console.ReadLine();

                Console.WriteLine("Rate: ");

                var rate = float.Parse(Console.ReadLine());

                CurrencyExchanger.AddCurrency(iso, rate);

                Console.WriteLine("Currency has been added!" + "\nPress backspace to return to the main menu...");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nEnter backspace to return...");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace) ;
        }
    }
}
