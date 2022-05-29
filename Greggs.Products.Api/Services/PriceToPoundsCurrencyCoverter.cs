namespace Greggs.Products.Api.Services
{
    public static class PriceToPoundsCurrencyCoverter
    {
        private static decimal ExchangeRate => 1.0m;

        public static decimal ConvertToPounds(decimal basePrice)
        {
            return basePrice * ExchangeRate;
        }
    }
}
