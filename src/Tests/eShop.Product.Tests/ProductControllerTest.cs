namespace eShop.Product.Tests
{
    using Xunit;
    using Moq;
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;
    using eShop.Product.RestService.Controllers;
    using Microsoft.Extensions.Logging;

    public class ProductsControllerTests
    {
        [Fact]
        /// <summary>
        /// Tests that the Product method returns Ok when the product exists.
        /// </summary>
        /// TODO: mockAppLogic.Handle vraci neustale chybne NULL misto podstrceneho vysledku, 
        ///         kontrola parametru a vysledku je OK
        ///         proverit spravnost setupu, verzi knihovny....
        public void GetProduct_ReturnsOk_WhenProductExists()
        {
            // Arrange
            var mockAppLogic = new Mock<ApplicationLogic.Interfaces.IeShopApplicationLogic>();
            var mockMapper = new Mock<IMapper>();
            var mockLogger = new Mock<ILogger<ProductController>>();

            mockAppLogic.Setup(s => s.Handle(new eShop.Product.RestService.RequestMessages.GetProductByIdReqMsg
            { productId = 1 }))
                .Returns(new ApplicationLogic.UseCases.Models.ProductByIdResponseMsg
                { Product = new eShop.Product.Frameworks.Types.Product 
                    { 
                        Id = 1, 
                        Description = "Description1", 
                        Name = "Product1", 
                        Price = 23, 
                        ImageUri = "url"
                    }});

            var controller = new ProductController(mockAppLogic.Object, mockMapper.Object, mockLogger.Object);

            //// Act
            var result = controller.Product(1);

            //// Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var product = Assert.IsType<RestService.Models.Product>(okResult.Value);
            Assert.Equal(1, product.Id);
        }
    }
}

