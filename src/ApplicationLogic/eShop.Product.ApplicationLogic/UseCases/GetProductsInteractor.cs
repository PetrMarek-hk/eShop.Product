namespace eShop.Product.ApplicationLogic.UseCases;

using eShop.Product.ApplicationLogic.RequestMessages;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.ApplicationLogic.UseCases.Models;
using eShop.Product.Frameworks.Types;
using eShop.Product.Types;

[eShop.Product.ApplicationLogic.RequestToInteractorMapping(typeof(IGetProductsReqMsg))]
internal class GetProductsInteractor : eShop.Product.ApplicationLogic.Interfaces.IAppLogicInteractorGen<IGetProductsReqMsg, IProductsResponseMsg>
{
    private readonly IProductRepository repository;

    public GetProductsInteractor(IProductRepository repository)
    {
        this.repository = repository;
    }

    public IProductsResponseMsg Handle(IGetProductsReqMsg requestMessage)
    {
        var ret = this.repository.GetProducts(requestMessage.pageNumber, requestMessage.pageSize);

        return new ProductsResponseMsg
        {
            Products = ret
        };

    }
}