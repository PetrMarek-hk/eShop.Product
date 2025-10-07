using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Frameworks.Types
{
    public class Product : eShop.Product.Types.IProduct
    {
        /// <summary>
        /// Get or sets the product identifier.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Get or sets the product name.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Get or sets the product image URL.
        /// </summary>
        public string ImageUri { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Get or sets the product description.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
