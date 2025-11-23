using MGMApi.Models;

namespace MGMApi.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Models.Product> _products = new List<Models.Product>()
        {
            new Models.Product{Pid=101,Name= "Laptop", Price=50000 },
            new Models.Product{Pid=102,Name= "Mobile", Price=80000 },
            new Models.Product{Pid=103,Name= "LCD", Price=30000 },
            new Models.Product{Pid=104,Name= "KeyBoard", Price=1000 },
        };
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() => _products;
      

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
