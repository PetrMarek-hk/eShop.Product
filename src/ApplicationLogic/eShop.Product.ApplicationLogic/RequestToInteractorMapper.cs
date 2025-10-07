using eShop.Product.ApplicationLogic.Interfaces;

namespace eShop.Product.ApplicationLogic
{
    internal class RequestToInteractorMapper : IRequestToInteractorMapper
    {
        private IDictionary<Type, Type> requestMsgToInteractorMap;

        public RequestToInteractorMapper()
        {
            // Mapping between request message interface types and message handlers.
            this.MapRequestMessagesToHandlers();
        }

        public Type GetInteractorType(IApplicationLogicRequestMessage requestMessage)
        {
            var reqMsgInterfaceType = this.GetBaseInterface(requestMessage.GetType());

            if (!this.requestMsgToInteractorMap.TryGetValue(reqMsgInterfaceType, out var interactorType))
            {
                throw new InvalidOperationException($"No interactor found for request message type {requestMessage.GetType()}");
            }

            return interactorType;
        }

        private void MapRequestMessagesToHandlers()
        {
            var assembly = typeof(RequestToInteractorMapper).Assembly;

            var interactorTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.GetCustomAttributes(typeof(RequestToInteractorMappingAttribute), false).Any());

            this.requestMsgToInteractorMap = interactorTypes
                .Select(interactorType =>
                {
                    var attribute = (RequestToInteractorMappingAttribute)interactorType
                    .GetCustomAttributes(typeof(RequestToInteractorMappingAttribute), false)
                    .First();

                    return new
                    {
                        RequestMessageType = attribute.RequestMessageType,
                        InteractorType = interactorType
                    };
                })
                .ToDictionary(mapping => mapping.RequestMessageType, mapping => mapping.InteractorType);
        }

        private Type GetBaseInterface(Type instanceType)
        {
            if (instanceType.IsInterface)
            {
                return instanceType;
            }

            var interfaces = instanceType.GetInterfaces();
            if (interfaces.Any())
            {
                return interfaces.First();
            }

            return instanceType;
        }
    }

}
