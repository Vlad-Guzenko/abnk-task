namespace Currency_conventer.Scenarios
{
    public class BaseScenario
    {
        protected CurrencyExchanger CurrencyExchanger;

        public BaseScenario(CurrencyExchanger currencyExchanger)
        {   
            CurrencyExchanger = currencyExchanger;
        }
        public virtual void Run() {}
    }
}
