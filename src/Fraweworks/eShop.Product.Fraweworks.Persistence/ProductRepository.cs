using eShop.Product.Frameworks.Types;
//using eShop.Product.Fraweworks.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.Frameworks.Persistence
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
        }
        /// <summary>
        /// Gets product by id
        /// </summary>
        /// <param name="id">id of product</param>
        /// <returns>IProduct</returns>
        public eShop.Product.Types.IProduct GetProductById(int id)
        {
            var context = getContext();

            var product = context.Products
                .Where(p => p.Id == id)
                .ToList<eShop.Product.Types.IProduct>()
                .FirstOrDefault();
            return product;
        }
        /// <summary>
        /// Gets list of products
        /// </summary>
        /// <param name="pageNumber">page number</param>
        /// <param name="pageSize">page size</param>
        /// <returns>list od Product</returns>
        public IList<eShop.Product.Types.IProduct> GetProducts(int pageNumber, int pageSize)
        {
            var context = getContext();
            if (pageNumber < 1) pageNumber = 1;
            if (pageSize < 1) pageSize = 10;

            var products = context.Products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList<eShop.Product.Types.IProduct>();
            return products;
        }
        /// <summary>
        /// Update product description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <returns>update product</returns>
        public eShop.Product.Types.IProduct UpdateProduct(int id, string description)
        {
            var context = getContext();
            var product = context.Products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                // Modify description
                product.Description = description;

                context.SaveChanges();
            }

            var productRet = context.Products
                .Where(p => p.Id == id)
                .ToList<eShop.Product.Types.IProduct>()
                .FirstOrDefault();
            return productRet;
        }

        /// <summary>
        /// Gets DB context
        /// </summary>
        /// <returns>context</returns>
        private ProductContext getContext()
        {
            var options = new DbContextOptionsBuilder<ProductContext>()
                 .UseSqlite(@"Data Source=Db\eShop.db")
                .Options;

            var context = new ProductContext(options);
            // create DB if dosnt exists
            context.Database.EnsureCreated();

            // fill data if is empty
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    Enumerable.Range(1, 150).Select(index => new eShop.Product.Frameworks.Types.Product
                    {
                        Id = index,
                        Name = $"Product {index}",
                        Description = $"Description for product {index}",
                        Price = Random.Shared.Next(10, 1000),
                        ImageUri = $@"\Goods\Eletronics\Product{index}.pgn",
                    }).ToArray()
                );

                context.SaveChanges();
            }
            return context;
        }
    }
}
