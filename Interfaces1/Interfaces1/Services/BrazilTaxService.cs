namespace Interfaces1.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount > 100.0)
            {
                return amount * 0.15;
            }
            else
            {
                return amount * 0.2;
            }
        }
    }
}
