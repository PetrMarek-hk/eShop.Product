namespace eShop.Product.RestService.Models;

using eShop.Product.Contracts;

/// <summary>
/// Update product description
/// </summary>
internal class UpdateProduct : IUpdateProduct
{
    /// <summary>
    /// Get or sets the product identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Get or sets the product description.
    /// </summary>
    public string Description { get; set; }
}
