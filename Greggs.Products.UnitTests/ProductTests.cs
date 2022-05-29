using Greggs.Products.Api.Models;
using NUnit.Framework;

namespace Greggs.Products.UnitTests
{
    [TestFixture]
    public class ProductTests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product { Name = "Sausage Roll", Price = 1m };
        }

        [Test]
        public void Contains_correct_price_in_pound()
        {
            Assert.AreEqual(1.0m, _product.PriceInPounds);
        }

        [Test]
        public void Contains_correct_price_in_euros()
        {
            Assert.AreEqual(1.11m, _product.PriceInEuros);
        }
    }
}