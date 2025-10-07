namespace eShop.Product.ApplicationLogic.RequestMessages;

using eShop.Product.ApplicationLogic.Interfaces;
using eShop.Product.Types;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public interface IGetProductByIdReqMsg : IApplicationLogicRequestMessage
{
    /// <summary>
    /// Gets or sets the product Id.
    /// </summary>
    int productId { get; set; }
}
