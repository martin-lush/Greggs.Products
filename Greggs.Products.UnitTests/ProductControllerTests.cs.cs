using Greggs.Products.Api.Controllers;
using Greggs.Products.Api.DataAccess;
using Greggs.Products.Api.Models;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Greggs.Products.UnitTests;

[TestFixture]
public class ProductControllerTests
{
    private IEnumerable<Product> _productDatabase;
    private Mock<IDataAccess<Product>> _dataAccess;
    private ProductController _controller;

    [SetUp]
    public void SetUp()
    {
        _productDatabase = new List<Product>()
        {
            new() { Name = "Sausage Roll", Price = 1m },
            new() { Name = "Vegan Sausage Roll", Price = 1.1m },
            new() { Name = "Steak Bake", Price = 1.2m },
        };

        _dataAccess = new Mock<IDataAccess<Product>>();
        _controller = new ProductController(Mock.Of<ILogger<ProductController>>(), _dataAccess.Object);

        _dataAccess.Setup(x => x.List(It.IsAny<int>(), It.IsAny<int>())).Returns(_productDatabase);
    }

    [Test]
    public void Uses_data_access_to_get_products()
    {
        var result = _controller.Get();

        _dataAccess.Verify(x => x.List(It.IsAny<int>(), It.IsAny<int>()), Times.Once());
    }

    [Test]
    public void Returns_expected_products()
    {
        var result = _controller.Get();

        CollectionAssert.AreEquivalent(_productDatabase, result);
    }
}