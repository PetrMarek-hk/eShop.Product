using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Contracts.Responses
{
    public interface IProductsResponse
    {
        /// <summary>
        /// Gets or sets the list of products.
        /// </summary>
        IList<IProduct> Products { get; set; }
    }
}
