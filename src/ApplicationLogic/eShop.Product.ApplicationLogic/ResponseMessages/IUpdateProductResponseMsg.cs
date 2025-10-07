namespace eShop.Product.ApplicationLogic.ResponseMessages;

using eShop.Product.ApplicationLogic.Interfaces;
using eShop.Product.Types;

public interface IUpdateProductResponseMsg : IApplicationLogicResponseMessage
{
    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    IProduct Product { get; set; }
}
