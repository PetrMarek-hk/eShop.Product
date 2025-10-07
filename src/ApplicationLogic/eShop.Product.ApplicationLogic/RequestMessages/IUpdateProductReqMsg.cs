namespace eShop.Product.ApplicationLogic.RequestMessages;

using eShop.Product.ApplicationLogic.Interfaces;
using eShop.Product.Types;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public interface IUpdateProductReqMsg : IApplicationLogicRequestMessage
{
    /// <summary>
    /// Gets or sets the product Id.
    /// </summary>
    int productId { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    string description { get; set; }

}
