using eShop.Product.ApplicationLogic.RequestMessages;

namespace eShop.Product.RestService.RequestMessages
{
    public class GetProductsReqMsg : IGetProductsReqMsg
    {
        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        public int pageNumber { get; set; }
        /// <summary>
        /// Get or sets the page size.
        /// </summary>
        public int pageSize { get; set; }
    }
}
