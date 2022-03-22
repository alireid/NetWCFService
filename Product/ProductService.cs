
namespace ProductBL
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;

    public class ProductService
    {
        private IList<Product> Products { get; set; }

        public ProductService()
        {
            if (File.Exists("./ProductDBFile.dat"))
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream("./ProductDBFile.dat", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    this.Products = (List<Product>)formatter.Deserialize(stream);
                }
            }
            else
            {
                this.Products = new List<Product>();
                SeedProducts();
            }
        }

        private void SeedProducts()
        {        
            // 1st Product
            this.Products.Add( 
                new Product()
                {
                    Id = 1,
                    Name = "Laptop",
                    Desc = "This is a computer"
                });

            // 2nd Product
            this.Products.Add(
                new Product()
                {
                    Id = 2,
                    Name = "Mouse",
                    Desc = "This is a mouse"
                });

            // 3rd Product
            this.Products.Add(
                new Product()
                {
                    Id = 3,
                    Name = "Keyboard",
                    Desc = "This is a keyboard"
                });

            SaveProduct();
        }

        private void SaveProduct()
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("./ProductDBFile.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, this.Products);
            }
        }

        public IList<Product> GetProducts()
        {
            return this.Products;
        }

        public Product GetProductById(int id)
        {
            return this.Products.SingleOrDefault(Product => Product.Id == id);
        }

        public void UpdateProduct(Product ProductForUpdate)
        {
            Product updateProduct = this.Products.SingleOrDefault(Product => Product.Id == ProductForUpdate.Id);

            if (updateProduct != null)
            {
                // Employ advantage of List - Remove and Add Functions! Not a real application
                // No need for any validations
                this.Products.Remove(updateProduct);
                this.Products.Add(ProductForUpdate);
                SaveProduct();
            }
        }

        public void CreateProduct(Product addNewProduct)
        {
            int lastProductdId = this.Products.Max(Product => Product.Id);
            addNewProduct.Id = lastProductdId + 1;
            this.Products.Add(addNewProduct);
            SaveProduct();
        }

        public void DeleteProduct(int ProductId)
        {
            Product deleteProduct = this.Products.SingleOrDefault(Product => Product.Id == ProductId);
            this.Products.Remove(deleteProduct);
            SaveProduct();
        }
    }
}
