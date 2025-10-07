namespace eShop.Product.ApplicationLogic.RequestMessages;

using eShop.Product.ApplicationLogic.Interfaces;
using eShop.Product.Types;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public interface IGetProductsReqMsg : IApplicationLogicRequestMessage
{
    /// <summary>
    /// Gets or sets the page number.
    /// </summary>
    int pageNumber { get; set; }
    /// <summary>
    /// Get or sets the page size.
    /// </summary>
    int pageSize { get; set; }
}
