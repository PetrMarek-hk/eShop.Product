using AutoMapper;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.ApplicationLogic.UseCases.Models;
using eShop.Product.RestService.Responses.Models;
using eShop.Product.RestService.RequestMessages;
using Microsoft.AspNetCore.Mvc;
using eShop.Product.RestService.Extensions;

namespace eShop.Product.RestService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly eShop.Product.ApplicationLogic.Interfaces.IeShopApplicationLogic _appLogic;
        private readonly IMapper _mapper;

        private readonly ILogger<ProductController> _logger;

        public ProductController(eShop.Product.ApplicationLogic.Interfaces.IeShopApplicationLogic appLogic,
            IMapper mapper,
            ILogger<ProductController> logger)
        {
            _appLogic = appLogic;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("Products")]
        public ActionResult<Contracts.Responses.IProductsResponse> Products(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10
            )
        {
            var ret = (IProductsResponseMsg)this._appLogic
                .Handle(new GetProductsReqMsg { pageNumber = pageNumber, pageSize = pageSize });
            return this.Ok(ret.ToProductsResponse(this._mapper));
        }

        [HttpGet("Product/{productId:int}")]
        public ActionResult<Contracts.Responses.IProductResponse> Product(int productId)
        {
            var ret = (IProductByIdResponseMsg)this._appLogic
                .Handle(new GetProductByIdReqMsg { productId = productId});

            return this.Ok(ret.ToProductResponse(this._mapper));
        }
    }
}
