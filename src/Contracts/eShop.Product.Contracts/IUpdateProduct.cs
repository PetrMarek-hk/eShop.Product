using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Contracts
{
    /// <summary>
    /// Contract for product update
    /// </summary>
    public interface IUpdateProduct
    {
        /// <summary>
        /// Get or sets the product identifier.
        /// </summary>
        int Id { get; set; }
 
        /// <summary>
        /// Get or sets the product description.
        /// </summary>
        string Description { get; set; }
    }
}
