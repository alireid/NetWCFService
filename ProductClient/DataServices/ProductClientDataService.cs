
namespace ProductClient.DataServices
{
    using System.Collections.Generic;
    using ProductClient.WCFProductService;

    class ProductClientDataService
    {
        private ProductServiceClient _client;

        public ProductClientDataService()
        {
            _client = new WCFProductService.ProductServiceClient();
        }
        public IList<Product> GetProducts()
        {
            return _client.GetProducts();
        }

        public Product GetProductByID(int ProductId)
        {
            return _client.GetProductByID(ProductId);
        }

        public void CreateProduct(Product newProduct)
        {
            _client.CreateProduct(newProduct);
        }

        public void UpdateProduct(Product updateProduct)
        {
            _client.UpdateProduct(updateProduct);
        }

        public void DeleteProduct(int deleteProductId)
        {
            _client.DeleteProduct(deleteProductId);
        }
    }
}
