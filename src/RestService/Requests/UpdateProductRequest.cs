using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using eShop.Product.Contracts;
using eShop.Product.Contracts.Requests;
using eShop.Product.RestService.Converters;

//using eShop.Product.RestService.Converters;
using eShop.Product.RestService.Models;

namespace eShop.Product.RestService.Requests
{
    public class UpdateProductRequest : IUpdateProductRequest
    {
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        [JsonConverter(typeof(ClassConverter<UpdateProduct, IUpdateProduct>))]
        [Required]
        public IUpdateProduct Product { get; set; }
    }
}
