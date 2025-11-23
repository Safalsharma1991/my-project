using ProductWebApi.Models;

namespace ProductWebApi.Repo
{
    public class ProductRepo : IProductRepo
    {
        public void AddProduct(Product product)
        {
            product.Pid = this.product.Max(p => p.Pid) + 1;
            this.product.Add(product);

        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
        private readonly List<Product> product = new List<Product>()
        {
            new Product(){Pid= 101, Name = "Mushroom", Price = 2000},
            new Product(){Pid= 102, Name = "Cake", Price = 4000},
            new Product(){Pid= 103, Name = "Sussage", Price = 5000}
        };

        public List<Product> GetAllProducts() => product;

        public Product GetById(int id) => product.FirstOrDefault(p => p.Pid == id) ?? new Product();


        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
