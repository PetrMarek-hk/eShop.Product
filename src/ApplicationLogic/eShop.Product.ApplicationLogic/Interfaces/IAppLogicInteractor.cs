namespace eShop.Product.ApplicationLogic.Interfaces;


internal interface IAppLogicInteractor
{
    IApplicationLogicResponseMessage Handle(IApplicationLogicRequestMessage requestMessage);
}
