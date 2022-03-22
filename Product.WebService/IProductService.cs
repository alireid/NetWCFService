
namespace Product.WebService
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using ProductBL;

    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        IList<Product> GetProducts();

        [OperationContract]
        Product GetProductByID(int ProductId);

        [OperationContract]
        void CreateProduct(Product newProduct);

        [OperationContract]
        void UpdateProduct(Product updateProduct);

        [OperationContract]
        void DeleteProduct(int deleteProductId);
    }
}
