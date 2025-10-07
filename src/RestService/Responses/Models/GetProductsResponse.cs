namespace eShop.Product.RestService.Responses.Models
{
    using System.Collections.Generic;
    using eShop.Product.Contracts.Responses;

    /// <summary>
    /// The products response.
    /// </summary>
    internal class GetProductsResponse : IProductsResponse
    {
        /// <summary>
        /// Gets or sets the list of products.
        /// </summary>
        public IList<eShop.Product.Contracts.IProduct> Products { get; set; }
    }
}