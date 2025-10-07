namespace eShop.Product.RestService.Models;

using eShop.Product.Contracts;

/// <summary>
/// External lawyer data object
/// </summary>
internal class Product : IProduct
{
    /// <summary>
    /// Get or sets the product identifier.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Get or sets the product name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Get or sets the product image URL.
    /// </summary>
    public string ImageUri { get; set; }
    /// <summary>
    /// Gets or sets the product price.
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// Get or sets the product description.
    /// </summary>
    public string Description { get; set; }
}
