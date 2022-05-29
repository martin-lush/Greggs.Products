using Greggs.Products.Api.Services;

namespace Greggs.Products.Api.Models;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal PriceInPounds => PriceToPoundsCurrencyCoverter.ConvertToPounds(Price);
    public decimal PriceInEuros => PriceToEurosCurrencyCoverter.ConvertToEuros(Price);
}