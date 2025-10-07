using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Product.ApplicationLogic.Interfaces
{
    /// <summary>
    /// The IeShopApplicationLogic interface.
    /// </summary>
    public interface IeShopApplicationLogic
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="requestMessage"> The request message. </param>
        /// <returns> The <see cref="IApplicationLogicResponseMessage"/>. </returns>
        public IApplicationLogicResponseMessage Handle(IApplicationLogicRequestMessage requestMessage);
    }
}
