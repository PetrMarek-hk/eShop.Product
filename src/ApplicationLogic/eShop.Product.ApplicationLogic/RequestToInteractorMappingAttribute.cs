using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.ApplicationLogic
{
    /// <summary>
    /// Attribute to map request messages (interfaces) to their corresponding interactor classes.
    /// The attribute must be applied to interactor classes, and it specifies the type of the request message that the interactor handles.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class RequestToInteractorMappingAttribute : Attribute
    {
        public Type RequestMessageType { get; }

        public RequestToInteractorMappingAttribute(Type requestMessageType)
        {
            this.RequestMessageType = requestMessageType;
        }
    }
}
