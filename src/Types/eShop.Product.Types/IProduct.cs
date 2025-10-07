namespace eShop.Product.Types
{
    public interface IProduct
    {
        /// <summary>
        /// Get or sets the product identifier.
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Get or sets the product name.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Get or sets the product image URL.
        /// </summary>
        string ImageUri { get; set; }
        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        decimal Price { get; set; }
        /// <summary>
        /// Get or sets the product description.
        /// </summary>
        string Description { get; set; }
    }
}
