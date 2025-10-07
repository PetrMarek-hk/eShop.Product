using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.Types;

namespace eShop.Product.ApplicationLogic.UseCases.Models
{
    public class ProductByIdResponseMsg : IProductByIdResponseMsg
    {
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public IProduct Product { get; set; }
    }
}
