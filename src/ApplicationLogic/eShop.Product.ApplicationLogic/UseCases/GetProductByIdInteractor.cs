namespace eShop.Product.ApplicationLogic.UseCases;

using eShop.Product.ApplicationLogic.RequestMessages;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.ApplicationLogic.UseCases.Models;
using eShop.Product.Frameworks.Types;

[eShop.Product.ApplicationLogic.RequestToInteractorMapping(typeof(IGetProductByIdReqMsg))]
internal class GetProductByIdInteractor : Interfaces.IAppLogicInteractorGen<IGetProductByIdReqMsg, IProductByIdResponseMsg>
{
    private readonly IProductRepository repository;

    public GetProductByIdInteractor(IProductRepository repository)
    {
        this.repository = repository;
    }

    public IProductByIdResponseMsg Handle(IGetProductByIdReqMsg requestMessage)
    {
        var ret = this.repository.GetProductById(requestMessage.productId);

        return new ProductByIdResponseMsg
        {
            Product = ret
        };
    }
}