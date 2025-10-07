namespace eShop.Product.ApplicationLogic;

using eShop.Product.ApplicationLogic.Interfaces;

/// <summary>
/// The eShop application logic.
/// </summary>
internal class eShopApplicationLogic : IeShopApplicationLogic
{
    private readonly IServiceProvider serviceProvider;
    private readonly IRequestToInteractorMapper requestToInteractorMapper;

    public eShopApplicationLogic(IServiceProvider serviceProvider, IRequestToInteractorMapper requestToInteractorMapper)
    {
        this.serviceProvider = serviceProvider;
        this.requestToInteractorMapper = requestToInteractorMapper;
    }

    /// <summary>
    /// The handle method.
    /// </summary>
    /// <param name="requestMessage"> The request message. </param>
    /// <returns> The <see cref="IApplicationLogicResponseMessage"/>. </returns>
    public IApplicationLogicResponseMessage Handle(IApplicationLogicRequestMessage requestMessage)
    {
        var interactorType = this.requestToInteractorMapper.GetInteractorType(requestMessage);
        if (interactorType == null)
        {
            throw new InvalidOperationException($"Unknown request message type: {requestMessage.GetType()}.");
        }

        var interactor = this.serviceProvider.GetService(interactorType) as IAppLogicInteractor;
        if (interactor == null)
        {
            throw new InvalidOperationException($"Interactor of type {interactorType} is not registered in the DI container.");
        }

        return interactor.Handle(requestMessage);
    }
}