
namespace eShop.Product.Types
{
    public interface IProducts
    {
        /// <summary>
        /// Gets or sets the list of products.
        /// </summary>
        IList<IProduct> Items { get; set; }
    }
}
