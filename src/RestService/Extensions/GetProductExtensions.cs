namespace eShop.Product.RestService.Extensions;

using AutoMapper;

using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.RestService.Responses.Models;
using eShop.Product.RestService.Models;
using eShop.Product.Contracts.Responses;
using eShop.Product.Frameworks.Types;
using System.Diagnostics.Contracts;


internal static class GetProductExtensions
{
    //public static IProductResponse ToProductResponse(this IProductByIdResponseMsg responseMessage, IMapper mapper)
    //{
    //    return mapper.Map<IProductResponse>(responseMessage);
    //}
    public static IProductResponse ToProductResponse(this IProductByIdResponseMsg responseMessage, IMapper mapper)
    {
        return new GetProductByIdResponse
        {
            Product = new eShop.Product.RestService.Models.Product
            {
                Id = responseMessage.Product.Id,
                Name = responseMessage.Product.Name,
                ImageUri = responseMessage.Product.ImageUri,
                Price = responseMessage.Product.Price,
                Description = responseMessage.Product.Description,
            }
        };
    }
}
