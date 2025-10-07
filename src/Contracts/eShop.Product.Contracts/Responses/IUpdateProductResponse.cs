using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Contracts.Responses
{
    public interface IUpdateProductResponse
    {
        IProduct Product { get; set; }
    }
}
