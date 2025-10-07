using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using eShop.Product.Types;
//using eShop.Product.Types;

namespace eShop.Product.Frameworks.Types
{
    public interface IProductRepository
    {
        /// <summary>
        /// Gets product by id
        /// </summary>
        /// <param name="id">id of product</param>
        /// <returns>IProduct</returns>
        eShop.Product.Types.IProduct GetProductById(int id);
        /// <summary>
        /// Gets list of products
        /// </summary>
        /// <param name="pageNumber">page number</param>
        /// <param name="pageSize">page size</param>
        /// <returns>list od IProduct</returns>
        IList<eShop.Product.Types.IProduct> GetProducts(int pageNumber, int pageSize);
        /// <summary>
        /// Update product description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        eShop.Product.Types.IProduct UpdateProduct(int id, string description);
    }
}
