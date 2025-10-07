namespace eShop.Product.RestService.Extensions;

using AutoMapper;
using eShop.Product.RestService.Responses.Models;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.RestService.Models;
using eShop.Product.Contracts.Responses;
using eShop.Product.Frameworks.Types;
using System.Diagnostics.Contracts;


internal static class GetProductsExtensions
{
    public static IProductsResponse ToProductsResponse(this IProductsResponseMsg responseMessage, IMapper mapper)
    {
        return new GetProductsResponse
        {
            Products = responseMessage.Products.ToProductsList()
        };
    }
    public static IList<eShop.Product.Contracts.IProduct> ToProductsList(this IList<eShop.Product.Types.IProduct> list)
    {
        return list.Select(item => item.ToProduct()).ToList();
 
    }
    public static eShop.Product.Contracts.IProduct ToProduct(this eShop.Product.Types.IProduct item)
    {
        return new eShop.Product.RestService.Models.Product
        {
            Id = item.Id,
            Name = item.Name,
            ImageUri = item.ImageUri,
            Price = item.Price,
            Description = item.Description,
        };
    }

}
