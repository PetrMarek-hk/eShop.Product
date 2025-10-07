namespace eShop.Product.ApplicationLogic.UseCases;

using eShop.Product.ApplicationLogic.RequestMessages;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.ApplicationLogic.UseCases.Models;
using eShop.Product.Frameworks.Types;
using eShop.Product.Types;

[eShop.Product.ApplicationLogic.RequestToInteractorMapping(typeof(IUpdateProductReqMsg))]
internal class UpdateProductInteractor : eShop.Product.ApplicationLogic.Interfaces.IAppLogicInteractorGen<IUpdateProductReqMsg, IUpdateProductResponseMsg>
{
    private readonly IProductRepository repository;

    public UpdateProductInteractor(IProductRepository repository)
    {
        this.repository = repository;
    }

    public IUpdateProductResponseMsg Handle(IUpdateProductReqMsg requestMessage)
    {
        var ret = this.repository.UpdateProduct(requestMessage.productId, requestMessage.description);

        return new UpdateProductResponseMsg
        {
            Product = ret
        };

    }
}