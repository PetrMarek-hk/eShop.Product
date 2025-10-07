using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Contracts
{
    public interface IProducts
    {
        /// <summary>
        /// Gets or sets the list of products.
        /// </summary>
        IList<IProduct> Items { get; set; }
    }
}
