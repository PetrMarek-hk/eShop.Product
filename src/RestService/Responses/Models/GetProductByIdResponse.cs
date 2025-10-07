namespace eShop.Product.RestService.Responses.Models
{
    using System.Collections.Generic;
    using eShop.Product.ApplicationLogic.ResponseMessages;
    using eShop.Product.Contracts;
    using eShop.Product.Contracts.Responses;

    /// <summary>
    /// The products response.
    /// </summary>
    internal class GetProductByIdResponse : eShop.Product.Contracts.Responses.IProductResponse
    {
        public IProduct Product { get; set; }
    }
}