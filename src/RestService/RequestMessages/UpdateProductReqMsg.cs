using eShop.Product.ApplicationLogic.RequestMessages;

namespace eShop.Product.RestService.RequestMessages
{
    public class UpdateProductReqMsg : IUpdateProductReqMsg
    {
        /// <summary>
        /// Gets or sets the product Id.
        /// </summary>
        public int productId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string description { get; set; }
    }
}
