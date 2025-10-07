using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Contracts.Requests
{
    public interface IUpdateProductRequest
    {
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        IUpdateProduct Product { get; set; }
    }
}
