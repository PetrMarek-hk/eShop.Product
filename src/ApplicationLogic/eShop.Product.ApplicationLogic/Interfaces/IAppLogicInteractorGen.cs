namespace eShop.Product.ApplicationLogic.Interfaces;

internal interface IAppLogicInteractorGen<TRequestMessage, TResponseMessage> : IAppLogicInteractor
    where TRequestMessage : IApplicationLogicRequestMessage
    where TResponseMessage : IApplicationLogicResponseMessage
{
    TResponseMessage Handle(TRequestMessage requestMessage);

    IApplicationLogicResponseMessage IAppLogicInteractor.Handle(IApplicationLogicRequestMessage requestMessage)
    {
        return this.Handle((TRequestMessage)requestMessage);
    }
}
