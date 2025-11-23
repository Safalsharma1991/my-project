using ProductWebApi.Models;

namespace ProductWebApi.Repo
{
    public interface IProductRepo
    {
        List<Models.Product> GetAllProducts();
        Product GetById(int id);
        void AddProduct(Models.Product product);
        void UpdateProduct(Models.Product product);
        void DeleteProduct(int id);

    }
}
