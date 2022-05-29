namespace Greggs.Products.Api.Services
{
    public static class PriceToEurosCurrencyCoverter
    {
        private static decimal ExchangeRate => 1.11m;

        public static decimal ConvertToEuros(decimal basePrice)
        {
            return basePrice * ExchangeRate;
        }
    }
}
