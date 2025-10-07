using eShop.Product.ApplicationLogic.RequestMessages;

namespace eShop.Product.RestService.RequestMessages
{
    public class GetProductByIdReqMsg : IGetProductByIdReqMsg
    {
        /// <summary>
        /// Gets or sets the product Id.
        /// </summary>
        public int productId { get; set; }
    }
}
