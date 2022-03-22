
namespace Product.WebService
{
    using System.Collections.Generic; 
    using ProductBL;

    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        private ProductBL.ProductService _businessLayerProductService;

        public ProductService()
        {
            _businessLayerProductService = new ProductBL.ProductService();
        }

        public IList<Product> GetProducts()
        {
            return _businessLayerProductService.GetProducts();
        }

        public Product GetProductByID(int ProductId)
        {
            return _businessLayerProductService.GetProductById(ProductId);
        }

        public void CreateProduct(Product newProduct)
        {
            _businessLayerProductService.CreateProduct(newProduct);
        }

        public void UpdateProduct(Product updateProduct)
        {
            _businessLayerProductService.UpdateProduct(updateProduct);
        }

        public void DeleteProduct(int deleteProductId)
        {
            _businessLayerProductService.DeleteProduct(deleteProductId);
        }
    }
}
