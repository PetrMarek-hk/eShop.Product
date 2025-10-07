namespace eShop.Product.ApplicationLogic.ResponseMessages;

using eShop.Product.ApplicationLogic.Interfaces;
using eShop.Product.Types;

public interface IProductsResponseMsg : IApplicationLogicResponseMessage
{
    IList<IProduct> Products { get; set; }
}
